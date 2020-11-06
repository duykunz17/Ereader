using Ereader.Models;
using Ereader.ViewModels.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ereader.Queries
{
    public class PageQuery
    {
        public List<PageViewModel> getPageInTheme(int idTheme)
        {
            var db = new eReaderNoLoginContext();
            try
            {
                var list = (from p in db.Page
                            join t in db.Theme on p.IdTheme equals t.Id
                            where p.Deleted == 0 && p.IdTheme == idTheme
                            orderby p.PageIndex ascending
                            select new PageViewModel
                            {
                                Id = p.Id,
                                Image = Convert.ToBase64String(p.ImageFile),
                                PageIndex = p.PageIndex
                            }).ToList();
                return list;
            }
            catch (Exception e)
            {
                //LogBasic.Error("PageQuery.GetPageInTheme", e);
                return null;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
