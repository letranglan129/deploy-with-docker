using DockerPublishSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DockerPublishSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly SchoolDB _db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(SchoolDB db, ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            try
            {
                var x = _db.Students.First();
                ViewData["name"] = x.name;
            }
            catch (Exception ex)
            {
                ViewData["name"] = ex.ToString();
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return new JsonResult(new { song = 123 });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
