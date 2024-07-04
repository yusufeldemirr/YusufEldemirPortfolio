using CasgemPortfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioDbEntities db = new CasgemPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.featureImage = db.TblFeature.Select(x => x.FeatureImageUrl).FirstOrDefault();

            return PartialView();
        }
        public PartialViewResult PartialWhoIAm()
        {
            ViewBag.title = db.TblWhoAmI.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = db.TblWhoAmI.Select(x => x.Description).FirstOrDefault();
            return PartialView();
        }
        public ActionResult Download()
        {
            ViewBag.cv = db.TblWhoAmI.Select(x => x.CvLink).FirstOrDefault();
            string filePath = Server.MapPath("~/Templates/" + ViewBag.cv);
            return File(filePath, "application/pdf", ViewBag.cv);
        }
        public PartialViewResult PartialMyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x => x.MessageSubject == "Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialVideo()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            var textArray = db.TblSkill.Select(x => x.SkillName).ToArray();
            ViewBag.skillArray = textArray;
            return PartialView();
        }
    }
}