using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeXemPhim.Controllers
{
    public class KhuyenmaiController : Controller
    {
        // GET: Khuyenmai
        public ActionResult Khuyenmai()
        {
            return View();
        }

        // GET: Khuyenmai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Khuyenmai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Khuyenmai/Create
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

        // GET: Khuyenmai/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Khuyenmai/Edit/5
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

        // GET: Khuyenmai/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Khuyenmai/Delete/5
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
