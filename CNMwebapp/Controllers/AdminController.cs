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

            return RedirectToAction(nameof(JobManager));
        }


        [Authorize(Roles = "Admin")]
        public IActionResult JobManager()
        {
            return View(_db.Jobs);
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


        [Authorize(Roles = "Admin")]
        public ActionResult CreateJob()
        {
            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateJob(Job job)
        {
            job.Uid = Guid.NewGuid().ToString();
            job.Workers = new List<Worker>(job.WorkersNeeded);
            _db.Jobs.Add(job);
            _db.SaveChanges();
            return RedirectToAction(nameof(JobManager));
        }


        [Authorize(Roles = "Admin")]
        public ActionResult DeleteJob(string jobid)
        {
            var job = _db.Jobs.FirstOrDefault(j => j.Uid == jobid);
            if (job != null)
            {
                _db.Jobs.Remove(job);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(JobManager));
        }


        [Authorize(Roles = "Admin")]
        public ActionResult DeleteUser(string id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(UserManager));
        }
    }
}
