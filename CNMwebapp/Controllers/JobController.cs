using CNMwebapp.Data;
using CNMwebapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            return View();
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
            job.OwnerId =  _userManager.GetUserId(this.User);
            _db.Jobs.Add(job); 
            _db.SaveChanges();
            return RedirectToAction(nameof(Jobs));
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
