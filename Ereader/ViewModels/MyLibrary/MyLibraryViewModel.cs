using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ereader.ViewModels.MyLibrary
{
    public class MyLibraryViewModel
    {
        public string Name { get; set; }
        public List<ThemeLevelViewModel> ListTheme { get; set; }
        
    }

    public class ThemeLevelViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }

}
