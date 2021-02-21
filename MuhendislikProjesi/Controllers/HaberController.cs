using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MuhendislikProjesi.Models.Siniflar;
namespace MuhendislikProjesi.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        Context c = new Context();
        HaberDetaylar hd = new HaberDetaylar();
        public ActionResult Index()
        {
            var Haberler = c.Habers.ToList();
            hd.Degerim1 = c.Habers.OrderByDescending(x => x.HaberID).Take(5).ToList();
            hd.Degerim2 = c.Habers.OrderByDescending(x => x.HaberID).Take(15).ToList();
            return View(hd);
        }
    }
}