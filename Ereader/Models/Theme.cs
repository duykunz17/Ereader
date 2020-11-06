using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Theme
    {
        public Theme()
        {
            Page = new HashSet<Page>();
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdLevel { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public string Description { get; set; }
        public byte[] ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public string IdProduct { get; set; }
        public decimal? Price { get; set; }
        public int? Priority { get; set; }
        public int? Version { get; set; }
        public int? IdServer { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Level IdLevelNavigation { get; set; }
        public virtual ICollection<Page> Page { get; set; }
        public virtual ICollection<Question> Question { get; set; }
    }
}
