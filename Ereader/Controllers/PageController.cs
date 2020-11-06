using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ereader.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Ereader.Controllers
{
    public class PageController : Controller
    {
        PageQuery query;
        public PageController()
        {
            query = new PageQuery();
        }
        public IActionResult Index(int idTheme)
        {
            var model = query.getPageInTheme(idTheme);
            return View(model);
        }
    }
}
