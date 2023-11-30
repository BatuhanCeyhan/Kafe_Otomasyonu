using Kafe.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.DataAccsess.Concrete.Entity_Framework.Context
{
    public class KafeDbContext:DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Masa> Masa { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Adisyon> Adisyon { get; set; }
        public DbSet<Belirleme> Belirleme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BATU-DESKTOP;Database=Kafe_Projesi;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
