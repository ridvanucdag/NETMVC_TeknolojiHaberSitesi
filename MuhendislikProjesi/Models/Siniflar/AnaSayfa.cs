using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int HaberID { get; set; }
        public string HaberBaslik { get; set; }
        public string HaberAciklama { get; set; }
    }
}