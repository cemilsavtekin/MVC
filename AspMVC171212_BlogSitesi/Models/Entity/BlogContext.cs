using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspMVC171212_BlogSitesi.Models.Entity
{
    public class BlogContext:DbContext
    {
        public BlogContext():base("BlogDB")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }



    }
}