using CNMwebapp.Data;
using CNMwebapp.Models;
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


        public HomeController(UserManager<Worker> userManager, ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _userManager = userManager;
            _logger = logger;
            _db = db;

        }


        public IActionResult Index()
        {
            return View(_db.Jobs);
        }


        [Authorize]
        public async Task<IActionResult> Privacy()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            return View(user);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}