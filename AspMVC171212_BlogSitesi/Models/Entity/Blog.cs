using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspMVC171212_BlogSitesi.Models.Entity
{
    public class Blog
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Detay { get; set; }

        [NotMapped]
        public string Resim { get; set; }

        public DateTime Tarih { get; set; }



        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
    }
}