using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMVC171212_BlogSitesi.Models.Entity
{
    public class Personel
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}