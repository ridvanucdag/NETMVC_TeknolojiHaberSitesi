using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string KullaniAdi { get; set; }
        public string Sifre { get; set; }
    }
}