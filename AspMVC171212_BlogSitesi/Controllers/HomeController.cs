using AspMVC171212_BlogSitesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC171212_BlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.blogSayisi = db.Bloglar.Count();

            var bloglar = db.Bloglar.ToList();
            return View(bloglar);
        }
    }
}