//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web.Service.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Category1 = new HashSet<Category>();
            this.Items = new HashSet<Item>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> FeaturedItem { get; set; }
        public int Parent { get; set; }
    
        public virtual ICollection<Category> Category1 { get; set; }
        public virtual Category Category2 { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}