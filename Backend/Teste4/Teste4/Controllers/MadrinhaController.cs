using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste4.Models;


namespace Teste4.Controllers
{
    public class MadrinhaController : Controller
    {
        // GET: Madrinha
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult GetList()
        {
            List<Madrinha> mdrList = new List<Madrinha>();
            using (DBModels db = new DBModels()) 
            {
                mdrList = db.Madrinha.ToList<Madrinha>();
                return Json(new { data = mdrList },JsonRequestBehavior.AllowGet);
            }
        } 
    }
}