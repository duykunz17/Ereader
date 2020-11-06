using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class WebpagesUsersInRoles
    {
        public Guid UserRoleId { get; set; }
        public string NameProfile { get; set; }
        public Guid RoleId { get; set; }
        public string UserId { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual WebpagesRoles Role { get; set; }
        public virtual User User { get; set; }
    }
}
