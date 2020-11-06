using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class RightCategoryTypes
    {
        public RightCategoryTypes()
        {
            RightCategories = new HashSet<RightCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<RightCategories> RightCategories { get; set; }
    }
}
