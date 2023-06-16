using CNMwebapp.Data;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CNMwebapp.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<Worker> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<Worker> userManager, ILogger<HomeController> logger, ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _logger = logger;
            _db = db;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult JobManager()
        {
            return View(_db.Jobs);
        }

        public async Task<IActionResult> DelegateAdmin()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            var role = new IdentityRole()
            {
                Name = "Admin"
            };

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(role);
            }

            await _userManager.AddToRoleAsync(user, "Admin");

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin")]
        public IActionResult UserManager()
        {
            return View(_userManager.Users);
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);

            if (user == null)
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }

            return RedirectToAction(nameof(UserManager));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GrantAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);

            if (user == null)
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return RedirectToAction(nameof(UserManager));
        }
    }
}
