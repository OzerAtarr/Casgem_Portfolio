using Casgem_Portfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_Portfolio.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult PartialAbout()
        {
            ViewBag.title1 = db.TblAbout.Select(x => x.Title1).FirstOrDefault();
            ViewBag.title2 = db.TblAbout.Select(x => x.Title2).FirstOrDefault();
            ViewBag.description = db.TblAbout.Select(x => x.Description).FirstOrDefault();
            ViewBag.nameSurname = db.TblAbout.Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.city = db.TblAbout.Select(x => x.City).FirstOrDefault();
            ViewBag.age = db.TblAbout.Select(x => x.Age).FirstOrDefault();
            ViewBag.email = db.TblAbout.Select(x => x.Email).FirstOrDefault();
            ViewBag.cvUrl = db.TblAbout.Select(x => x.CvUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialInformation()
        {
            var values = db.TblWork.ToList();
            return PartialView(values);
        }
    }
}