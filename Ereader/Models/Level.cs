using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Level
    {
        public Level()
        {
            Theme = new HashSet<Theme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int? Priority { get; set; }
        public string BgColor { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Theme> Theme { get; set; }
    }
}
