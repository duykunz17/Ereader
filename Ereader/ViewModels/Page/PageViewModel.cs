using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ereader.ViewModels.Page
{
    public class PageViewModel
    {
        public int? Id { get; set; }
        public string Image { get; set; }
        public int? PageIndex { get; set; }
        public List<SentenceViewModel> ListSentence { get; set; }
    }

    public class SentenceViewModel
    {
        public int? IdSentence { get; set; }
        public string SoundFile { get; set; }
    }
}
