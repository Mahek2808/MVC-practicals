using FormAuthenticationInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuthenticationInMVC.Controllers
{
    public class HomeController : Controller
    {
        MovieEntities db = new MovieEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(login obj)
        {
            if(ModelState.IsValid)
            {
               var isvalid = db.logins.Where(x=> x.username== obj.username && x.password== obj.password).FirstOrDefault();

                if(isvalid!=null)
                {
                    FormsAuthentication.SetAuthCookie(obj.username, false);
                    return RedirectToAction("Index", "movies");
                }
                else
                {
                    ViewBag.Error = "Invalid Username or Password";
                    return View(obj);
                }
                
            }
         
            return View();
            
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Include = "username,password")]register obj)
        {
            db.registers.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Login","Home");
        }

    }
}