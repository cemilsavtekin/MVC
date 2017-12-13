using AspMVC171212_BlogSitesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AspMVC171212_BlogSitesi.Controllers
{
    [AllowAnonymous]
    public class IdentityController : Controller
    {
        BlogContext db = new BlogContext();

        // GET: Identity

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Personel uye)
        {
            var kullanici = db.Personeller.FirstOrDefault(x => x.KullaniciAdi == uye.KullaniciAdi && x.Sifre == uye.Sifre);

            if (kullanici != null)
            {
                //FormsAuthentication.SetAuthCookie(kullanici.KullaniciAdi, false);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                ViewBag.HataMesaji = "geçersiz kullanıcı veya şifre";
                return View();
            }


        }
    }
}