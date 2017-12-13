using System.Collections.Generic;

namespace AspMVC171212_BlogSitesi.Models.Entity
{
    public class Kategori
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}