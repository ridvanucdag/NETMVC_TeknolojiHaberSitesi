using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; }
        public string HakkimizdaFoto { get; set; }
        public string HakkimizdaAciklama { get; set; }
    }
}