using CNMwebapp.Data;
using CNMwebapp.Models;
using IdentityCore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CNMwebapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Worker> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;


        public HomeController(UserManager<Worker> userManager, ILogger<HomeController> logger, ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _logger = logger;
            _db = db;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            DummyData.Initialize(_db, _userManager, _roleManager).Wait();
            return View();
        }
  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}