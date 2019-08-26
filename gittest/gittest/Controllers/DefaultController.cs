using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gittest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string str = "test";


            return View();
        }
        public ActionResult Abc()
        {
            return View();
        }
    }
}