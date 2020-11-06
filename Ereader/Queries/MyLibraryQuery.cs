using Ereader.ViewModels.MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ereader.Models;

namespace Ereader.Queries
{
    public class MyLibraryQuery
    {
        public List<MyLibraryViewModel> getListMyLibrary()
        {
            var db = new eReaderNoLoginContext();
            try
            {
                var list = (from l in db.Level
                            where l.Deleted == 0
                            orderby l.Priority ascending
                            select new MyLibraryViewModel
                            {
                                Name = l.Name,
                                ListTheme = (List<ThemeLevelViewModel>)l.Theme.Where(m => m.Deleted == 0).Select(m => new ThemeLevelViewModel { 
                                    Id = m.Id,
                                    Name = m.Name,
                                    Image = Convert.ToBase64String(m.ImageFile)
                                }).ToList()
                            }).ToList();
                return list;
            }
            catch (Exception e)
            {
                //LogBasic.Error("MyLibraryQuery.GetListMyLibrary", e);
                return null;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
