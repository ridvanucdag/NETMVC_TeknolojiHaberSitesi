using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MuhendislikProjesi.Models.Siniflar;

namespace MuhendislikProjesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context hd = new Context();
        public ActionResult Index()
        {
            var degerler = hd.Habers.OrderByDescending(x => x.HaberID).Take(6).ToList();
            return View(degerler);
        }

        public ActionResult Hakkimizda()
        {
            var degerler = hd.Hakkimizdas.ToList();
            return View(degerler);
        }

        public ActionResult HaberDetay(int id)
        {
            var haberdetay = hd.Habers.Where(x => x.HaberID == id).ToList();
            return View(haberdetay);
        }
        public PartialViewResult Partial1()
        {
            var degerler = hd.Habers.OrderByDescending(x => x.HaberID).Take(15).ToList();
            return PartialView(degerler);

        }
        public PartialViewResult Partial2()
        {
            var degerler = hd.Habers.OrderByDescending(x => x.HaberID).Take(8).ToList();
            return PartialView(degerler);

        }

        public ActionResult iletisim()
        {
            return View();
        }
    }
}