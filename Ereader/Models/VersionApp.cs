using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class VersionApp
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public bool Mandatory { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
