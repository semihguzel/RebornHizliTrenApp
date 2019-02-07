using HızlıTrenApp.DAL.Repository.Abstract;
using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL.Repository.Concrete
{
    public class MusteriConcrete
    {
        public  IRepository<Musteri> _musteriRepository;
        private DbContext _dbContext;

        public MusteriConcrete()
        {
            _dbContext = new Context();
            _musteriRepository = new EFRepository<Musteri>(_dbContext);
        }

        public int GetIdByEntity(Musteri musteri)
        {
            return _musteriRepository.GetAll().Where(x => x.MusteriID == musteri.MusteriID).Select(x => x.MusteriID).FirstOrDefault();
        }
    }
}
