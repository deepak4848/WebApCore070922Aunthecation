using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApCore070922.Areas.Identity.Data;
using WebApCore070922.Models;

namespace WebApCore070922.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _db;
        private readonly UserManager<ApplicationUser> _manager;

        public HomeController(ILogger<HomeController> logger, DatabaseContext db, UserManager<ApplicationUser> manager)
        {
            _logger = logger;
            _db = db;
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor _Doc)
        {
            _db.Doctors.Add(_Doc);
            _db.SaveChanges();
            return RedirectToAction("Show");
        }

        public IActionResult Show()
        {
            var user = _manager.GetUserName(HttpContext.User);
            var data = _db.Doctors.Where(x => x.EmailId == user).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Delete(int id = 0)
        {
            var data = _db.Doctors.Find(id);
            _db.Doctors.Remove(data);
            _db.SaveChanges();
            return RedirectToAction("Show");
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}