﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Service.Model;

namespace web.Models
{
    public class ItemInProgress
    {
        public ItemInProgress()
        {
            Blobs = new List<Blob>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public List<Blob> Blobs { get; set; }
        public ItemType ItemType { get; set; }
    }

    public enum ItemType
    {
        Map,
        Server,
        TexturePack,
        Mod,
        Skin
    }
}