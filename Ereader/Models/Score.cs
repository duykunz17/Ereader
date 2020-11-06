using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class Score
    {
        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public string NameTheme { get; set; }
        public int? TotalQuestion { get; set; }
        public int? RightAnswer { get; set; }
        public int? TotalScore { get; set; }
        public DateTime? Date { get; set; }
        public string MobileId { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? IdAccount { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UserName { get; set; }
    }
}
