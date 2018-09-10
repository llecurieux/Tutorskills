using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        TutorskillsDb _db = new TutorskillsDb();

        public ActionResult Home()
        {
            //go to SQLServer retreive all the posts and put them into a list
            var model = _db.Posts.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);

        }         
    }
}