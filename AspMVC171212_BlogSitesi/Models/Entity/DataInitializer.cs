using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspMVC171212_BlogSitesi.Models.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {Ad="C#" },
                new Kategori() {Ad="Java" },
                new Kategori() {Ad="Python" },
                new Kategori() {Ad="Kotlin" },
                new Kategori() {Ad="Web" }
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017"),KategoriID=1 },
                 new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017"),KategoriID=1 },
                 new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017") ,KategoriID=2},
                  new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017"),KategoriID=3 },
                   new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017") ,KategoriID=4},
                    new Blog() {Baslik="Delegates",Detay="C# delegates are similar to pointers to functions, in C or C++. A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime. Delegates are especially used for implementing events and the call - back methods.All delegates are implicitly derived from the System.Delegate class.", Tarih=DateTime.Parse("11/11/2017"),KategoriID=5 }

            };


            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();
        }
    } 
}