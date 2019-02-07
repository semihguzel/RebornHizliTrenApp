using HızlıTrenApp.DATA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL.Repository.Concrete
{
    public class YoneticiDal
    {
        public Yonetici GetByUserNamePasword(string username, string password)
        {
            using (Context db = new Context())
            {
                return db.Yonetici.FirstOrDefault(x => x.Username == username && x.Password == password);
            }
        }
    }
}
