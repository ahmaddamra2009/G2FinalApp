using G2FinalApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.blogs = _db.Blogs.ToList();
            return View(_db.Products.ToList());
        }
    }
}
