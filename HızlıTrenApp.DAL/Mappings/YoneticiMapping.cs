using HızlıTrenApp.DATA;
using HızlıTrenApp.DATA.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL.Mappings
{
    public class YoneticiMapping :EntityTypeConfiguration<Yonetici>
    {
        public YoneticiMapping()
        {
            HasKey(x => x.YoneticiID);

            Property(x => x.Username).HasMaxLength(30);
            Property(x => x.Password).HasMaxLength(30);
        }
    }
}
