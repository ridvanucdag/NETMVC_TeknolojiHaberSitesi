using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class Yorum
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumlar { get; set; }

        public int HaberID { get; set; }
        public virtual Haber Haber { get; set; }
    }
}