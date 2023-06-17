using CNMwebapp.Data;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CNMwebapp.Controllers
{
    public class JobController : Controller
    {

        private readonly UserManager<Worker> _userManager;
        private readonly ApplicationDbContext _db;

        public JobController(UserManager<Worker> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }



        [Authorize]
        public IActionResult Jobs()
        {
            return View(_db.Jobs);
        }

     
        public ActionResult SignUp(string userid, string jobid)
        {
            var job = _db.Jobs.FirstOrDefault(x=>x.Uid==jobid);
            var user = _db.Users.FirstOrDefault(x=>x.Id==userid);

            if (user != null && job != null 
                && job.Workers.Count() < job.WorkersNeeded
                && !job.Workers.Contains(user)) 
            {
                job.Workers.Add(user);
                user.Schedule.Add(job);
                _db.SaveChanges();
            }
            
            return RedirectToAction(nameof(Jobs));
        }


       
    }
}
