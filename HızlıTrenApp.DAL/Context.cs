using HızlıTrenApp.DAL.Mappings;
using HızlıTrenApp.DATA;
using HızlıTrenApp.DATA.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server=.; database = HizliTrenDb; uid = sa; pwd = 123";
        }
        //saasdasd
        public DbSet<Bilet> Bilet { get; set; }
        public DbSet<BiletBilgi> BiletBilgi { get; set; }
        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<MusteriDetay> MusteriDetay { get; set; }
        public DbSet<RezerveBilet> RezerveBilet { get; set; }
        public DbSet<SatilanBilet> SatilanBilet { get; set; }
        public DbSet<Sefer> Sefer { get; set; }
        public DbSet<SeferSaat> SeferSaat { get; set; }
        public DbSet<SeferSeferSaat> SeferSeferSaat { get; set; }
        public DbSet<Unvan> Unvan { get; set; }
        public DbSet<Yonetici> Yonetici { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BiletMapping());
            modelBuilder.Configurations.Add(new BiletBilgiMapping());
            modelBuilder.Configurations.Add(new SatilanBiletMapping());
            modelBuilder.Configurations.Add(new RezerveBiletMapping());

            modelBuilder.Configurations.Add(new CalisanMapping());
            modelBuilder.Configurations.Add(new UnvanMapping());

            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new MusteriDetayMapping());
            modelBuilder.Configurations.Add(new SeferMapping());
            modelBuilder.Configurations.Add(new SeferSaatMapping());
            modelBuilder.Configurations.Add(new SeferSeferSaatMapping());

            modelBuilder.Configurations.Add(new YoneticiMapping());



            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
