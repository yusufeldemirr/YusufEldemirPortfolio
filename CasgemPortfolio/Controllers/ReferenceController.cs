using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CasgemPortfolio.Models.Entities;

namespace CasgemPortfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioDbEntities db = new CasgemPortfolioDbEntities();

        public ActionResult Index()
        {
            var values = db.TblReference.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReference(TblReference reference)
        {
            db.TblReference.Add(reference);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteReference(int id)
        {
            var values = db.TblReference.Find(id);
            db.TblReference.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            var values = db.TblReference.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateReference(TblReference reference)
        {
            var values = db.TblReference.Find(reference.ReferenceID);
            values.ReferenceName = reference.ReferenceName;
            values.ReferenceSurname = reference.ReferenceSurname;
            values.ReferenceInfo = reference.ReferenceInfo;
            values.ReferenceImage = reference.ReferenceImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialStyle()
        {
            return PartialView();
        }
    }
}