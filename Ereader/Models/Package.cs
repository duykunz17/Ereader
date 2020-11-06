using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Package
    {
        public int Id { get; set; }
        public string IdProduct { get; set; }
        public int? IdTheme { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
