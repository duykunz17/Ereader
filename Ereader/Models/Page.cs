using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Page
    {
        public Page()
        {
            SentenceInPage = new HashSet<SentenceInPage>();
        }

        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public int? PageIndex { get; set; }
        public byte[] ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public byte[] VideoFile { get; set; }
        public string VideoName { get; set; }
        public string VideoType { get; set; }
        public int? Type { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Theme IdThemeNavigation { get; set; }
        public virtual ICollection<SentenceInPage> SentenceInPage { get; set; }
    }
}
