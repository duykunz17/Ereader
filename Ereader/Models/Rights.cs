using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Rights
    {
        public Rights()
        {
            RolesInRights = new HashSet<RolesInRights>();
        }

        public Guid RightsId { get; set; }
        public int? Indexes { get; set; }
        public string RightsName { get; set; }
        public string Label { get; set; }
        public string RightsDescription { get; set; }
        public int? CategoryId { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public bool? IsDefault { get; set; }
        public int? OrderIndex { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual RightCategories Category { get; set; }
        public virtual ICollection<RolesInRights> RolesInRights { get; set; }
    }
}
