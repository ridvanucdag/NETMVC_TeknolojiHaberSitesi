using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MuhendislikProjesi.Models.Siniflar;

namespace MuhendislikProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context a = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin gr)
        {
            var giris = a.Admins.FirstOrDefault(x => x.KullaniAdi == gr.KullaniAdi && x.Sifre == gr.Sifre);
            if(giris != null)
            {
                FormsAuthentication.SetAuthCookie(giris.KullaniAdi, false);
                Session["KullaniciAdi"] = giris.KullaniAdi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Default");
        }
    }
}