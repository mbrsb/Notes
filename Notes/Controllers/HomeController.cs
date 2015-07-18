using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvc.Models;

namespace Notes.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }  
            
        }
        public ActionResult Reg()
        {
            return View();
        }
    }
}