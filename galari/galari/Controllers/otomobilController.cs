using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using galari.viewmodel;

namespace galari.Controllers
{
    public class otomobilController : Controller
    {
        //
        // GET: /otomobil/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult oCreate()
        {
            otomobilviewmodel omodel = new otomobilviewmodel();
            return View(omodel);
            
        }
    }
}
