using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using galari.viewmodel;

namespace galari.Controllers
{
    public class müsteriController : Controller
    {
        //
        // GET: /müsteri/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {


            müsteriviewmodel model = new müsteriviewmodel();
            return View(model);
        }

        [HttpPost]
        public JsonResult Create(müsteriviewmodel model) {
             jsonresultmodel jmodel = new jsonresultmodel();
            try
            {
                galari.Models.otogalariEntities db = new Models.otogalariEntities();
                galari.Models.müsteri müsmodel = new Models.müsteri();
                müsmodel.mAdi = model.mAdi;
                müsmodel.mSoyadi = model.mSoyadi;
                müsmodel.mOtoID = model.mOtoID;
                müsmodel.mOtoadi = model.mOtoadi;
                db.müsteri.Add(müsmodel);
                db.SaveChanges();
               
                jmodel.IsSucces = true;
                jmodel.UserMessage = "kayıt işlemi başarı ile gerçekleştirildi";
            }
            catch (Exception e)
            {

                jmodel.IsSucces = false;
                jmodel.UserMessage = "HATA" + e.Message;
            }


            return Json(jmodel, JsonRequestBehavior.AllowGet);

        
        
        }


    }
}

