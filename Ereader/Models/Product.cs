using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? AppId { get; set; }
        public string AppName { get; set; }
        public int? Type { get; set; }
        public int? NumDay { get; set; }
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
