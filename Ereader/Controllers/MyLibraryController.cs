using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ereader.Models;
using Ereader.Queries;
using Ereader.ViewModels.MyLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ereader.Controllers
{
    public class MyLibraryController : Controller
    {
        MyLibraryQuery query;
        public MyLibraryController()
        {
            query = new MyLibraryQuery();
        }
        public IActionResult Index()
        {
            var model = query.getListMyLibrary();
            return View(model);
        }
    }
}
