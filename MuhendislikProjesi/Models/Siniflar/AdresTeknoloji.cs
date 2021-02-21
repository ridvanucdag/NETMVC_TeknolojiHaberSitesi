using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class AdresTeknoloji
    {
        [Key]
        public int AdresID { get; set; }
        public string AdresDetay { get; set; }
        public string AdresMail { get; set; }
        public string AdresTelefon { get; set; }
        public string AdresKonum { get; set; }
    }
}