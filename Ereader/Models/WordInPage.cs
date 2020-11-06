using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class WordInPage
    {
        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public int? IdSentence { get; set; }
        public string Word { get; set; }
        public TimeSpan? Time { get; set; }
        public int? Priority { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SentenceInPage IdSentenceNavigation { get; set; }
    }
}
