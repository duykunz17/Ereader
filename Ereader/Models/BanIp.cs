using System;
using System.Collections.Generic;

namespace Ereader.Models
{
    public partial class BanIp
    {
        public int Id { get; set; }
        public string Ipadress { get; set; }
        public int? Status { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? WrongNum { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? IdBranch { get; set; }
    }
}
