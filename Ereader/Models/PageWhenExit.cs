using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class PageWhenExit
    {
        public int Id { get; set; }
        public int? IdTheme { get; set; }
        public string NameTheme { get; set; }
        public int? IdPage { get; set; }
        public string MobileId { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? IdAccount { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
