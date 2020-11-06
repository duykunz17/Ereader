using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class WebpagesRoles
    {
        public WebpagesRoles()
        {
            RolesInRights = new HashSet<RolesInRights>();
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string DefaultController { get; set; }
        public string DefaultAction { get; set; }
        public int RoleOder { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<RolesInRights> RolesInRights { get; set; }
        public virtual ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
