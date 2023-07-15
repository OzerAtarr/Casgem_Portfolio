using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        CasgemPortfolioEntities db = new CasgemPortfolioEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(TblMessage p)
        {
            db.TblMessage.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }

        public PartialViewResult PartialContact()
        {
            var values = db.TblContact.ToList();
            ViewBag.number = db.TblContact.Select(x => x.Number).FirstOrDefault();
            ViewBag.email = db.TblContact.Select(x => x.Email).FirstOrDefault();
            ViewBag.adress = db.TblContact.Select(x => x.Adress).FirstOrDefault();
            return PartialView(values);
        }
    }
}