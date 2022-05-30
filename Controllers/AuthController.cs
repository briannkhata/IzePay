using IzePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace IzePay.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
               
                using (IZEPAYEntities db = new IZEPAYEntities())
                    {
                        var user = db.Users.Where(a => a.UserName == username && a.Password == password).FirstOrDefault();
                        if (user != null)    
                        {
                            Session["UserName"] = user.UserName.ToString();
                            Session["Name"] = user.Name.ToString();
                            Session["Role"] = user.Role.ToString();
                            return RedirectToAction("Index", "Home");

                        }
                        else    
                        {
                            TempData["userErrorMsg"] = "Wrong Username or Password";
                            return View("Index");
                        }
                }


            }
            return RedirectToAction("Index");

        }

        public ActionResult Logout()
        {
              Session.Abandon();
              Session.Remove("UserName");
              Session.Remove("Password");
              return RedirectToAction("Index");
        }
        // POST: Auth/Create
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

        // GET: Auth/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auth/Edit/5
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

        // GET: Auth/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auth/Delete/5
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
