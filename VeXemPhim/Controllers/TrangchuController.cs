using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeXemPhim.Controllers
{
    public class TrangchuController : Controller
    {
        // GET: Trangchu
        public ActionResult Trangchu()
        {
            return View();
        }

        // GET: Trangchu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trangchu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trangchu/Create
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

        // GET: Trangchu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trangchu/Edit/5
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

        // GET: Trangchu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trangchu/Delete/5
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
