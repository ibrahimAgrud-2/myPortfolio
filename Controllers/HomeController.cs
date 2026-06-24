using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;
using Portfolio.ViewModels;
using System.Diagnostics;
using System.Net.Http.Json;
namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly appDbContext _context;
          private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _apiBaseUrl;
        private object configuration;

        public HomeController(ILogger<HomeController> logger, appDbContext context, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _logger = logger;
            _context = context;
            _httpClientFactory = httpClientFactory;
            _apiBaseUrl = configuration["ApiBaseUrl"];
        }
      


        //veriyi çekip view'a göndereceðiz
        public async Task<IActionResult> IndexAsync()
        {
          

            HomeViewModel model= new HomeViewModel();



            // model.about = _context.aboutMe.FirstOrDefault();

            var client = _httpClientFactory.CreateClient();
            model.about = await client.GetFromJsonAsync<aboutMe>($"{_apiBaseUrl}/api/aboutme/2");




            //model.projects = _context.project.ToList();
            model.projects = await client.GetFromJsonAsync<List<project>>($"{_apiBaseUrl}/api/projects");

            //  model.education = _context.education.ToList();
            model.education = await client.GetFromJsonAsync<List<education>>($"{_apiBaseUrl}/api/education");



            //model.skill = _context.skill.ToList();
           model.skill = await client.GetFromJsonAsync<List<skills>>($"{_apiBaseUrl}/api/skills");

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
