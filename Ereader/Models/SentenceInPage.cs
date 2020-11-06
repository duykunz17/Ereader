using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class SentenceInPage
    {
        public SentenceInPage()
        {
            WordInPage = new HashSet<WordInPage>();
        }

        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public int? IdPage { get; set; }
        public string Word { get; set; }
        public string Color { get; set; }
        public int? DownLine { get; set; }
        public int? Position { get; set; }
        public byte[] SoundFile { get; set; }
        public string SoundName { get; set; }
        public string SoundType { get; set; }
        public int? Priority { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Page IdPageNavigation { get; set; }
        public virtual ICollection<WordInPage> WordInPage { get; set; }
    }
}
