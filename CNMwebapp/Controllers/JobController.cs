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

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Job job)
        {
            job.Uid = Guid.NewGuid().ToString();
            job.Workers = new List<Worker>(job.WorkersNeeded);
            _db.Jobs.Add(job); 
            _db.SaveChanges();
            return RedirectToAction(nameof(Jobs));
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


        public ActionResult Delete(string jobid)
        {
            var job= _db.Jobs.FirstOrDefault(j=>j.Uid==jobid);
            if(job!=null)
            {
                _db.Jobs.Remove(job);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Jobs));
        }
    }
}
