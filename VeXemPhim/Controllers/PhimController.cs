﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeXemPhim.Controllers
{
    public class PhimController : Controller
    {
        // GET: Phim
        public ActionResult Phim()
        {
            return View();
        }

        // GET: Phim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Phim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phim/Create
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

        // GET: Phim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Phim/Edit/5
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

        // GET: Phim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Phim/Delete/5
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
