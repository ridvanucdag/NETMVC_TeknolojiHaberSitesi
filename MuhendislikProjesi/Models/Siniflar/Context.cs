using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuhendislikProjesi.Models.Siniflar
{
    public class Context :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Haber> Habers { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<AdresTeknoloji> AdresTeknolojis { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
    }
}