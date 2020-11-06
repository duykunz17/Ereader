using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public string Answer1 { get; set; }
        public int? IdQuestion { get; set; }
        public int? Priority { get; set; }
        public int? Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Question IdQuestionNavigation { get; set; }
    }
}
