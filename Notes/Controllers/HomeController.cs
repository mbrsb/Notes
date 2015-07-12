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
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(User user)
        {
            return View();
        }
    }
}