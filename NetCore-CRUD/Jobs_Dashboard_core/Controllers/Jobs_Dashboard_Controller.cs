using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jobs_Dashboard_core.JobServices;
using Jobs_Dashboard_core.MiddleData;
using Jobs_Dashboard_core.Models;

namespace Jobs_Dashboard_core.Controllers
{
    public class Jobs_Dashboard_Controller : Controller
    {
        // GET: Jobs_Dashboard_
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jobs_Dashboard_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jobs_Dashboard_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jobs_Dashboard_/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Jobs_Dashboard_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jobs_Dashboard_/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Jobs_Dashboard_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jobs_Dashboard_/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}