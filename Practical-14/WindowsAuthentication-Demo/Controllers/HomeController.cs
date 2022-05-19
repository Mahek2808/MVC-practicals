using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsAuthentication_Demo.Models;

namespace WindowsAuthentication_Demo.Controllers
{
    [Authorize(Users = @"SF-CPU-465\rikesh, SF-CPU-465\Administrator")]
    public class HomeController : Controller
    {
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

        [Authorize(Users = @"SF-CPU-465\Administrator")]
        public ActionResult admin()
        {
            return View();
        }

        [Authorize(Users = @"SF-CPU-465\rikesh, SF-CPU-465\Administrator")]
        public ActionResult user()
        {
            return View();
        }

        students[] s1 = new students[]
        {
            new students {id=1, name="ABC", course="MBA", department="FOM" },

            new students {id=2, name="DEF",course="BCA",department="FOM"},

            new students {id=3,name="XYZ",course="B.Tech",department="ENGG"},

        };

        public IEnumerable<students> GetStudents()
        {
            return s1;
        }

        public ActionResult GetAllStudents()
        {
            return View(GetStudents());
        }
    }
}