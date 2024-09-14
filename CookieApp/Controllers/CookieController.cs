using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieApp.Controllers
{
    public class CookieController : Controller
    {
        // GET: Cookie

        public ActionResult SetCookie()
        {
            HttpCookie cookie = new HttpCookie("UserName");
            cookie.Value = "Samuel";
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);

            return View(); 
        }

    
        public ActionResult GetCookie()
        {
            HttpCookie cookie = Request.Cookies["UserName"];
            if (cookie != null)
            {
                ViewBag.CookieValue = cookie.Value;
            }
            else
            {
                ViewBag.CookieValue = null;
            }

            return View();
        }

      
        public ActionResult DeleteCookie()
        {
            HttpCookie cookie = new HttpCookie("UserName");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            return View();
        }
        public ActionResult Index()
        {
            return View(); 
        }
    }
}