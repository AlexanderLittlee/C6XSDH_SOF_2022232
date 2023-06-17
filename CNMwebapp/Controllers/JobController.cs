using CNMwebapp.Data;
using CNMwebapp.Logic;
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
        private readonly JobLogic _logic;

        public JobController(UserManager<Worker> userManager, ApplicationDbContext db, JobLogic logic)
        {
            _userManager = userManager;
            _db = db;
            _logic = logic;
        }

        [Authorize]
        public async Task<IActionResult> Schedule()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            return View(user);
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
            bool canSignUp = _logic.SignUpPossible(job, user);

            if (canSignUp) 
            {
                job.Workers.Add(user);
                user.Schedule.Add(job);
                _db.SaveChanges();
            }
            
            return RedirectToAction(nameof(Jobs));
        }

        public ActionResult Storno(string userid, string jobid)
        {
            var job = _db.Jobs.FirstOrDefault(x => x.Uid == jobid);
            var user = _db.Users.FirstOrDefault(x => x.Id == userid);
            bool canStorno = _logic.StornoPossible(job, user);

            if (canStorno)
            {
                job.Workers.Remove(user);
                user.Schedule.Remove(job);
                _db.SaveChanges();
            }

            return RedirectToAction(nameof(Schedule));
        }



    }
}
