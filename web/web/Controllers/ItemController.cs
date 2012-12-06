﻿using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;
using web.Service.Model;
using web.Shared;
using System.Web.Security;
using System.IO;
using IOFile = System.IO.File;
using System.Drawing;
using ICSharpCode.SharpZipLib.Zip;

namespace web.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult View(int id)
        {
            ItemViewModel viewModel;
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                if (item == null)
                    return HttpNotFound();
                viewModel = new ItemViewModel(item);
            }
            return View(viewModel);
        }

        public ActionResult JsonSearch(string query)
        {
            List<object> jsonItems = new List<object>();
            using (var database = new DatabaseEntities())
            {
                var items = (from i in database.Items
                        where i.Name.ToUpper().Contains(query.ToUpper()) ||
                                i.Description.ToUpper().Contains(query.ToUpper())
                        select i).Take(10).ToArray();
                foreach (var item in items)
                {
                    jsonItems.Add(new
                    {
                        id = item.Id,
                        name = item.Name,
                        user = item.User
                    });
                }
            }
            return Json(jsonItems.ToArray(), JsonRequestBehavior.AllowGet);
        }

        #region Adding Content

        [Authorize]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult Add(AddItemViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            var item = new ItemInProgress
            {
                Name = viewModel.Name,
                Description = viewModel.Description
            };
            Session["workingItem"] = item;
            switch (viewModel.Type)
            {
                case "Maps":
                    item.ItemType = ItemType.Map;
                    return RedirectToAction("AddMap");
                default:
                    return RedirectToAction("Add");
            }
        }

        [Authorize]
        public ActionResult AddMap()
        {
            var item = Session["workingItem"] as ItemInProgress;
            if (item == null || item.ItemType != ItemType.Map)
                return RedirectToAction("Add");
            return View(item);
        }

        [Authorize]
        public ActionResult Dependencies()
        {
            // TODO
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult UploadFile()
        {
            var item = Session["workingItem"] as ItemInProgress;
            if (item == null || item.ItemType == ItemType.Server)
                return Json(new { success = false });

            var reader = new StreamReader(Request.InputStream);
            var base64 = reader.ReadToEnd();
            byte[] file = Convert.FromBase64CharArray(base64.ToCharArray(), 0, base64.Length);
            var name = Request.Headers["x-file-name"];
            var user = Membership.GetUser();

            bool isImage;
            if (Path.GetExtension(name) == ".zip" || Path.GetExtension(name) == ".jar") isImage = false;
            else if (Path.GetExtension(name) == ".jpg" || Path.GetExtension(name) == ".png") isImage = true;
            else return Json(new { success = false, error = "Incorrect file format." });

            // Validate image size
            if (isImage)
            {
                try
                {
                    var image = Image.FromStream(new MemoryStream(file));
                    if (image.Width != 400 || image.Height != 250)
                        return Json(new { success = false, error = "Incorrect image size. Must be 400x250 pixels." });
                }
                catch
                {
                    return Json(new { success = false, error = "Invalid image file." });
                }
                if (item.ImageUrl != null)
                    return Json(new { success = false, error = "Image already selected!" });
            }
            // Validate archive
            else
            {
                var error = VerifyArchive(file, item);
                if (error != null)
                    return Json(new { success = false, error = error });
                if (item.Blobs.Count != 0)
                    return Json(new { success = false, error = "Zip file already selected!" });
            }

            // Check user directories
            var path = Path.Combine(Server.MapPath("~"), "data", user.UserName);
            Directory.CreateDirectory(path);
            foreach (var c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            int i = 1;
            string newName = name;
            string extension = Path.GetExtension(newName);
            newName = Path.GetFileNameWithoutExtension(newName);
            while (IOFile.Exists(Path.Combine(path, newName + extension)))
                newName = Path.GetFileNameWithoutExtension(name) + i++;
            IOFile.WriteAllBytes(Path.Combine(path, newName + extension), file);
            if (!isImage)
            {
                // Add blob
                var blob = new BlobViewModel
                {
                    DownloadUrl = "/data/" + user.UserName + "/" + newName + extension,
                    Name = Request.Headers["x-file-name"]
                };
                item.Blobs.Add(blob);
            }
            else
                item.ImageUrl = "/data/" + user.UserName + "/" + newName + extension;

            return Json(new { success = true });
        }

        private string VerifyArchive(byte[] file, ItemInProgress item)
        {
            try
            {
                using (ZipFile zipFile = new ZipFile(new MemoryStream(file)))
                {
                    switch (item.ItemType)
                    {
                        case ItemType.Map:
                            if (zipFile.GetEntry("level.dat") == null) return "Invalid world.";
                            // Should work without anything else, might be useful for just distributing seeds and such
                            return null;
                        case ItemType.Mod:
                            int classCount = 0;
                            foreach (ZipEntry entry in zipFile)
                            {
                                if (entry.IsFile && entry.Name.EndsWith(".class"))
                                    classCount++;
                            }
                            if (classCount == 0) return "Invalid JAR file.";
                            return null;
                        default:
                            return null;
                    }
                }
            }
            catch
            {
                return "Invalid archive.";
            }
        }

        [Authorize]
        public ActionResult ReviewItem()
        {
            var item = Session["workingItem"] as ItemInProgress;
            if (item == null)
                return RedirectToAction("Add");
            var viewModel = new ReviewItemViewModel();
            viewModel.Item = item;
            viewModel.Categories = new List<string>();
            using (var database = new DatabaseEntities())
            {
                switch (item.ItemType)
                {
                    case ItemType.Map:
                        viewModel.Categories = new List<string>(
                            from c in database.CategoryByName("Maps").Children
                            select c.Name);
                        break;
                }
            }
            viewModel.Categories.Insert(0, "None");
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult ReviewItem(ReviewItemViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);
            var item = Session["workingItem"] as ItemInProgress;
            if (item == null || Request.Form["category"] == null)
                return RedirectToAction("Add");

            Item dbItem;
            using (var database = new DatabaseEntities())
            {
                var category = database.CategoryByName(Request.Form["category"]);
                if (category != null)
                {
                    switch (item.ItemType)
                    {
                        case ItemType.Map:
                            if (!database.CategoryByName("Maps").Children.Contains(category))
                                return RedirectToAction("Add");
                            break;
                    }
                }
                dbItem = new Item();
                dbItem.Name = item.Name;
                dbItem.Description = item.Description;
                dbItem.User = Membership.GetUser().UserName;
                if (category != null)
                    dbItem.CategoryId = category.Id;
                dbItem.FriendlyVersion = viewModel.Version;
                dbItem.ImageUrl = item.ImageUrl;
                dbItem.Version = 0;
                dbItem.Approved = false;
                dbItem.Type = item.ItemType.ToString();
                database.Items.AddObject(dbItem);
                database.SaveChanges();
                // Add blobs
                foreach (var blob in item.Blobs)
                {
                    var dbBlob = new Blob();
                    dbBlob.DownloadUrl = blob.DownloadUrl;
                    dbBlob.DestinationPath = GetLocalPathForBlob(blob, item);
                    dbBlob.ItemId = dbItem.Id;
                    dbBlob.Name = blob.Name;
                    database.Blobs.AddObject(dbBlob);
                }

                // Add dependencies
                foreach (var dependency in item.Dependencies)
                {
                    var dbDependency = new Dependency();
                    dbDependency.DependencyItem = dependency.Id;
                    dbDependency.DependentItem = dbItem.Id;
                    database.Dependencies.AddObject(dbDependency);
                }
                database.SaveChanges();
            }

            return RedirectToAction("Index", "Web");
        }

        private string GetLocalPathForBlob(BlobViewModel blob, ItemInProgress item)
        {
            switch (item.ItemType)
            {
                case ItemType.Map:
                    return Path.Combine("saves", Path.GetFileName(blob.DownloadUrl));
                default:
                    return null;
            }
        }

        #endregion

        [Authorize]
        public ActionResult Edit(int id)
        {
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                if (item == null) return HttpNotFound();
                if (item.User != Membership.GetUser().UserName && !Membership.GetUser().IsAdministrator())
                    return new HttpUnauthorizedResult();
                var viewModel = new ItemViewModel(item);
                if (item.UpdatedBy.Any())
                    viewModel = new ItemViewModel(item.UpdatedBy.First());
                return View(viewModel);
            }
        }

        #region Editing Files

        [HttpPost]
        [Authorize]
        public ActionResult EditImage(int id)
        {
            var reader = new StreamReader(Request.InputStream);
            var base64 = reader.ReadToEnd();
            byte[] file = Convert.FromBase64CharArray(base64.ToCharArray(), 0, base64.Length);
            var name = Request.Headers["x-file-name"];
            var user = Membership.GetUser();

            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                if (item == null)
                    return Json(new { success = false, error = "Item not found." });
                if (item.User != user.UserName && !user.IsAdministrator())
                    return Json(new { success = false, error = "Unauthorized." });

                if (Path.GetExtension(name) != ".jpg" && Path.GetExtension(name) != ".png")
                    return Json(new {success = false, error = "Incorrect file format."});

                // Validate image size
                try
                {
                    var image = Image.FromStream(new MemoryStream(file));
                    if (image.Width != 400 || image.Height != 250)
                        return Json(new {success = false, error = "Incorrect image size. Must be 400x250 pixels."});
                }
                catch
                {
                    return Json(new {success = false, error = "Invalid image file."});
                }

                // Check user directories
                var path = Path.Combine(Server.MapPath("~"), "data", user.UserName);
                Directory.CreateDirectory(path);
                foreach (var c in Path.GetInvalidFileNameChars())
                    name = name.Replace(c, '_');
                int i = 1;
                string newName = name;
                string extension = Path.GetExtension(newName);
                newName = Path.GetFileNameWithoutExtension(newName);
                while (IOFile.Exists(Path.Combine(path, newName + extension)))
                    newName = Path.GetFileNameWithoutExtension(name) + i++;
                IOFile.WriteAllBytes(Path.Combine(path, newName + extension), file);

                if (item.ProvidesUpdate != null)
                    item.ImageUrl = "/data/" + user.UserName + "/" + newName + extension;
                else
                {
                    var update = new Item
                    {
                        Address = item.Address,
                        Approved = false,
                        CategoryId = item.CategoryId,
                        Description = item.Description,
                        FriendlyVersion = item.FriendlyVersion,
                        ImageUrl = "/data/" + user.UserName + "/" + newName + extension,
                        Name = item.Name,
                        ProvidesUpdate = item.Id,
                        Type = item.Type,
                        User = item.User,
                        Version = item.Version
                    };
                    database.Items.AddObject(update);
                    database.SaveChanges();
                    foreach (var dependency in item.Dependencies)
                    {
                        database.Dependencies.AddObject(new Dependency
                        {
                            DependencyItem = dependency.DependencyItem,
                            DependentItem = update.Id
                        });
                    }
                    foreach (var blob in item.Blobs)
                    {
                        database.Blobs.AddObject(new Blob
                        {
                            Name = blob.Name,
                            DestinationPath = blob.DestinationPath,
                            DownloadUrl = blob.DownloadUrl,
                            ItemId = update.Id
                        });
                    }
                }

                database.SaveChanges();

                return Json(new { success = true, url = item.ImageUrl });
            }
        }

        #endregion

        [Authorize]
        public ActionResult Delete(int id)
        {
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                if (item == null) return HttpNotFound();
                var viewModel = new ItemViewModel(item);
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, bool confirm)
        {
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                if (item == null)
                    return HttpNotFound();
                var user = Membership.GetUser();
                if (user.UserName == item.User || user.IsAdministrator())
                {
                    // Delete blobs
                    var blobs = item.Blobs.ToArray();
                    foreach (var blob in blobs)
                    {
                        database.DeleteObject(blob);
                        if (IOFile.Exists(Server.MapPath("~") + blob.DownloadUrl))
                            IOFile.Delete(Server.MapPath("~") + blob.DownloadUrl);
                    }
                    if (IOFile.Exists(Server.MapPath("~") + item.ImageUrl))
                        IOFile.Delete(Server.MapPath("~") + item.ImageUrl);
                    database.DeleteObject(item);
                    database.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Web");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Approve(int id)
        {
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                item.Approved = true;
                database.SaveChanges();
            }
            return Redirect("/Administration/Backlog");
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Unapprove(int id)
        {
            using (var database = new DatabaseEntities())
            {
                var item = database.ItemById(id);
                item.Approved = false;
                database.SaveChanges();
            }
            return Redirect("/Administration/Backlog");
        }
    }
}
