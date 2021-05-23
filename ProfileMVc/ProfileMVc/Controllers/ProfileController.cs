using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProfileMVc.Models;
using ProfileMVc.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileMVc.Controllers
{
    public class ProfileController : Controller
    {
        private IRepo<Profile> _repo;
        private ILogger<ProfileController> _logger;

        public ProfileController(IRepo<Profile> repo, ILogger<ProfileController> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: EmployeeController/Details/5
        public IActionResult Details()
        {
            try
            {
                List<Profile> profiles = _repo.GetAll().ToList();
                if (profiles == null)
                    return RedirectToAction("Error");
                return View(profiles);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }
        [HttpGet]
        // GET: EmployeeController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Profile profile)
        {
            try
            {
                _repo.Add(profile);
                return RedirectToAction("Details");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return View();
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}