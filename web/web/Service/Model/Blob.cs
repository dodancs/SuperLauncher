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
    
    public partial class Blob
    {
        public int Id { get; set; }
        public string DownloadUrl { get; set; }
        public string DestinationPath { get; set; }
        public int ItemId { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
