using CNMwebapp.Data;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CNMwebapp.Controllers
{
    public class JobController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public JobController(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }



        public IActionResult Index()
        {
            return RedirectToAction("Home", "Index", new { area = "" });
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Job job)
        {
            job.OwnerId =  _userManager.GetUserId(this.User);
            _db.Jobs.Add(job); 
            _db.SaveChanges();
            return RedirectToAction("Home", "Index", new { area = "" });
        }




        // GET: JobController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
