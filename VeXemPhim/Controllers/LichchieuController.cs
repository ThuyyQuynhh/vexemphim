using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeXemPhim.Controllers
{
    public class LichchieuController : Controller
    {
        // GET: Lichchieu
        public ActionResult Lichchieu()
        {
            return View();
        }

        // GET: Lichchieu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lichchieu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lichchieu/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lichchieu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lichchieu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lichchieu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lichchieu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
