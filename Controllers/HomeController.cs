using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio.Data;
using Portfolio.Models;
using Portfolio.ViewModels;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly appDbContext _context;

        public HomeController(ILogger<HomeController> logger, appDbContext context)
        {
            _logger = logger;
            _context = context;
        }
      


        //veriyi çekip view'a göndereceðiz
        public IActionResult Index()
        {
          

            HomeViewModel model= new HomeViewModel();
            model.about = _context.aboutMe.FirstOrDefault();
            model.education = _context.education.ToList();
            model.projects = _context.project.ToList(); 

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
