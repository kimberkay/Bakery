using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly BakeryContext _db;

        public HomeController(BakeryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
        ViewData["flavors"]= _db.Flavors.ToList();
        ViewData["treats"] = _db.Treats.ToList();
        return View();
       }
    }
}