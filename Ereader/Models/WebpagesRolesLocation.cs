using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class WebpagesRolesLocation
    {
        public int Id { get; set; }
        public Guid? RoleId { get; set; }
        public int? Priority { get; set; }
        public int? IdLocation { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
