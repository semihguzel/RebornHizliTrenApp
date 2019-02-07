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
    public class MusteriDetayConcrete
    {
        public IRepository<MusteriDetay> _musteriDetayRepository;
        private DbContext _dbContext;

        public MusteriDetayConcrete()
        {
            _dbContext = new Context();
            _musteriDetayRepository = new EFRepository<MusteriDetay>(_dbContext);
        }
    }
}
