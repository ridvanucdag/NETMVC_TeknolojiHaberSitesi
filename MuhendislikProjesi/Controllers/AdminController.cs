using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MuhendislikProjesi.Models.Siniflar;

namespace MuhendislikProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context b = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerim = b.Habers.ToList();
            return View(degerim);
        }
        [HttpGet]
        public ActionResult YeniHaber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHaber(Haber h)
        {
            b.Habers.Add(h);
            b.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult HaberSil(int id)
        {
            var a = b.Habers.Find(id);
            b.Habers.Remove(a);
            b.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult HaberDetay(int id)
        {
            var hc = b.Habers.Find(id);
            return View("HaberDetay" , hc);
        }
        public ActionResult HaberGuncelle(Haber ha)
        {
            var hg = b.Habers.Find(ha.HaberID);
            hg.HaberBaslik = ha.HaberBaslik;
            hg.HaberAciklama = ha.HaberAciklama;
            hg.HaberFoto = ha.HaberFoto;
            hg.HaberTarih = ha.HaberTarih;
            b.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Admin Ad)
        {
            b.Admins.Add(Ad);
            b.SaveChanges();
            return RedirectToAction("AdminEkleCikar");
        }

        public ActionResult AdminEkleCikar()
        {
            var eklecikar = b.Admins.ToList();
            return View(eklecikar);
        }
        public ActionResult AdminSil(int id)
        {
            var c = b.Admins.Find(id);
            b.Admins.Remove(c);
            b.SaveChanges();
            return RedirectToAction("AdminEkleCikar");
        }
        public ActionResult Hakkimizda()
        {
            var hakkimiz = b.Hakkimizdas.ToList();
            return View(hakkimiz);
        }

        public ActionResult HakkimizdaGuncelle(int id)
        {
            var hb = b.Hakkimizdas.Find(id);
            return View("Hakkimizda", hb);
        }
        public ActionResult HakkimizdaGuncelleme(Hakkimizda hd)
        {
            var hc = b.Hakkimizdas.Find(hd.HakkimizdaID);
            //hc.HakkimizdaFoto = hd.HakkimizdaFoto;
            hc.HakkimizdaAciklama = hd.HakkimizdaAciklama;
            b.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
    }
}