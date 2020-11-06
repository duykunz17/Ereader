using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Question
    {
        public Question()
        {
            Answer = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public string Question1 { get; set; }
        public int? IdAnswer { get; set; }
        public int? IdTheme { get; set; }
        public byte[] ImageFile { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public int? Priority { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public byte[] GameFile { get; set; }
        public string GameFolder { get; set; }
        public int? TypeQuestion { get; set; }

        public virtual Theme IdThemeNavigation { get; set; }
        public virtual ICollection<Answer> Answer { get; set; }
    }
}
