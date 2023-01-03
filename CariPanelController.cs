using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TechnoPau.Models.Sınıflar;

namespace TechnoPau.Controllers
{
    public class CariPanelController : Controller
    {
        // GET: CariPanel
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var carimail = (string)Session["Mail"];
            var degerler = c.Carilers.Where(x => x.Mail == carimail).ToList();
            ViewBag.m = carimail;
            return View(degerler);
        }
        public ActionResult Siparislerim()
        {
            var carimail = (string)Session["Mail"];
            var id = c.Carilers.Where(x => x.Mail == carimail.ToString()).Select(y => y.CariID).FirstOrDefault();
            var degerler = c.SatisHarekets.Where(x => x.CariID == id).ToList();
            return View(degerler);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult KargoTakip(string p)
        {
            var k = from x in c.KargoDetays select x;
                k = k.Where(y => y.TakipKodu.Contains(p));
            return View(k.ToList());
        }
        public ActionResult CariKargoTakip(string id)
        {
            var degerler = c.KargoTakips.Where(x => x.TakipKodu == id).ToList();
            return View(degerler);
        }
    }
}