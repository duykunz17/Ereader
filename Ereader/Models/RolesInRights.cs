using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class RolesInRights
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid RightsId { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Rights Rights { get; set; }
        public virtual WebpagesRoles Role { get; set; }
    }
}
