using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class VersionInfo
    {
        public int Id { get; set; }
        public int? Version { get; set; }
        public int? Type { get; set; }
        public string Desctiption { get; set; }
    }
}
