using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeXemPhim.Models;
namespace VeXemPhim.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
       
        RapPhimEntities1 db = new RapPhimEntities1();
        [HttpPost]
        public ActionResult Dangnhap(FormCollection f)
        {
            //ktra email va mat khau
            string sEmail = f["txtEmail"].ToString();
            string sMatkhau = f["txtMatkhau"].ToString();

            KhachHang kh = db.KhachHang.SingleOrDefault(n => n.email == sEmail && n.matKhau == sMatkhau);
            if(kh != null)
            {
                Session["Taikhoan"] = kh;
                return RedirectToAction("Trangchu", "Trangchu");
            }    


            return RedirectToAction("Trangchu","Trangchu");
        }
        
        public ActionResult Dangxuat()
        {
            Session["Taikhoan"] = null;
            return RedirectToAction("Trangchu", "Trangchu");
        }




        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
