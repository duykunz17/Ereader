using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class User
    {
        public User()
        {
            WebpagesUsersInRoles = new HashSet<WebpagesUsersInRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NameLogin { get; set; }
        public string Password { get; set; }
        public string UserEmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public string PassportIdNo { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public int? IdNationality { get; set; }
        public int? IdGenger { get; set; }
        public string Gender { get; set; }
        public int? MaritalStatusId { get; set; }
        public byte[] Images { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int? Deleted { get; set; }
        public int? IsActive { get; set; }
        public bool? WorkingHour { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual WebpagesMembershipss WebpagesMembershipss { get; set; }
        public virtual ICollection<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }
    }
}
