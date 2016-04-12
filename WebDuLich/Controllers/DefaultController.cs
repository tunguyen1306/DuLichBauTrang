using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDuLich.Models;

namespace WebDuLich.Controllers
{
    public class DefaultController : Controller
    {
        private WebDuLichEntities db = new WebDuLichEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slide()
        {
            var qs = from dataslide in db.tbl_slide_dulich
                     where dataslide.trangthai_silde_dulich == 1
                     select dataslide;
            return View();
        }

        public ActionResult Menu()
        {
            
            return View();
        }
        public ActionResult TieuBieu()
        {

            return View();
        }
        public ActionResult Header(int id)
        {
           

            return View();
        }

        public ActionResult Detail(string id)

        {
            var id_ =int.Parse( id.Split('-').Last());
            var qr = from dataNew in db.tbl_new_dulich
                     where dataNew.trangthai_new_dulich==1 && dataNew.id_new_dulich== id_
                     select dataNew;
            return View(qr.ToList());
        }
       
    }
}