using DemoDB1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDB1.Controllers
{
    public class LoginUserController : Controller
    {
        DBSportStoreEntities database = new DBSportStoreEntities();
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult LoginAccount(AdminUser _user)
        {
            var check = database.AdminUsers.Where(s => s.NameUser == _user.NameUser
            && s.PasswordUser == _user.PasswordUser).FirstOrDefault();
            // var check_ID = db.AdminUsers.Where(s => s.ID == _user.ID).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (check != null) //login sai thong tin
                {
                    ViewBag.ErrorInfo = "SaiInfo";
                    //return View("Index", _user);
                }
                else
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    Session["NameUser"] = _user.NameUser;
                    Session["PasswordUser"] = _user.PasswordUser;
                    return RedirectToAction("Index", "Product");
                }

            }
            return View();
        }
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(AdminUser _user)
        {
            if (ModelState.IsValid)
            {
                var check_ID = database.AdminUsers.Where(s => s.ID == _user.ID).FirstOrDefault();
                if (check_ID == null) //chua co ID
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    database.AdminUsers.Add(_user);
                    database.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorRegister = "This ID is exist";
                    return View();
                }
            }
            return View();
        }
        public ActionResult LogOutUser()
        {
            Session.Abandon();
            return RedirectToAction("Index", "LoginUser");
        }
    }
}