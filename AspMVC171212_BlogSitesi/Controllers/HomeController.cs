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
        public ActionResult Index(int? id,string q)
        {

            if (!string.IsNullOrEmpty(q))
            {
                var bloglar = db.Bloglar.Where(x => x.Baslik.Contains(q) || x.Detay.Contains(q) || x.Kategori.Ad.Contains(q)).ToList();

                ViewBag.blogSayisi = bloglar.Count();

                return View(bloglar);
            }


            if (id == null)
            {
                ViewBag.blogSayisi = db.Bloglar.Count();

                var bloglar = db.Bloglar.ToList();
                return View(bloglar);
            }
            else
            {
                

                var bloglar = db.Bloglar.Where(x=>x.KategoriID==id).ToList();
                ViewBag.blogSayisi = bloglar.Count();

                return View(bloglar);
            }

        }


        public ActionResult Details(int id)
        {
            return View(db.Bloglar.FirstOrDefault(x => x.ID == id));
        }

    }
}