using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class DeviceActive
    {
        public long Id { get; set; }
        public string IdDevice { get; set; }
        public string Name { get; set; }
        public string KeyActive { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public int? IdTheme { get; set; }
        public int? Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
