using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class Haber
    {
        [Key]
        public int HaberID { get; set; }
        public string HaberBaslik { get; set; }
        public DateTime HaberTarih { get; set; }
        public string HaberAciklama { get; set; }
        public string HaberFoto { get; set; }
        public ICollection<Yorum> Yorumlars { get; set; }
    }
}