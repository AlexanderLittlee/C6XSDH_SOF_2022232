using CNMwebapp.Data;
using CNMwebapp.Logic;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace CNMwebapp.Controllers
{
    public class JobController : Controller
    {

        private readonly UserManager<Worker> _userManager;
        private readonly ApplicationDbContext _db;
        private readonly IJobLogic _logic = new JobLogic();

        public JobController(UserManager<Worker> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
          
        }

        [Authorize]
        public async Task<IActionResult> Schedule()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            _logic.CheckExpiredJobs(user.Schedule, user);
            return View(user);
        }


        [Authorize]
        public IActionResult Jobs()
        {
            foreach (var job in _db.Jobs)
            {
                if (_logic.CheckExpiredJobs(job))
                    _db.Jobs.Remove(job);
                
            }
            _db.SaveChanges();
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
