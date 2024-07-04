using CasgemPortfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemPortfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioDbEntities db = new CasgemPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}