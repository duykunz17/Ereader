using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class RightCategories
    {
        public RightCategories()
        {
            Rights = new HashSet<Rights>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int? OrderIndex { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual RightCategoryTypes Type { get; set; }
        public virtual ICollection<Rights> Rights { get; set; }
    }
}
