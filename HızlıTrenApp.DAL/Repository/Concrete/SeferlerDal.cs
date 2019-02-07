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
    public class SeferlerDal
    {
        private IRepository<Sefer> _seferRepository;
        private DbContext _dbContext;

        public SeferlerDal()
        {
            _dbContext = new Context();
            _seferRepository = new EFRepository<Sefer>(_dbContext);
        }
      
        public List<Sefer> GetAllSeferler()
        {
            return _seferRepository.GetAll().ToList();
        }

        public  Sefer GetSeferIDByFilter(string nrdn,string nry)
        {
            using (Context db=new Context())
            {
                return db.Sefer.FirstOrDefault(x => x.SeferYonu.StartsWith(nrdn) && x.SeferYonu.EndsWith(nry));
            }
        }

        public void Add(Sefer sefer)
        {
            using (Context db=new Context())
            {
                db.Seferler.Add(sefer);
                db.SaveChanges();
            }
        }

        public void Delete(Sefer sefer)
        {
            using (Context db=new Context())
            {
                var entry = db.Entry(sefer);
                entry.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Update(Sefer sefer)
        {
            using (Context db=new Context())
            {
                var updatedEntity = db.Entry(sefer);
                updatedEntity.State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Sefer> GetSeferByContains(string sefer)
        {
            using (Context db=new Context())
            {
                return db.Seferler.Where(x => x.SeferYonu.Contains(sefer)).ToList();
            }
        }

        public List<Sefer> GetSeferlerByStartWith(string nrdn)
        {
            using (Context db=new Context())
            {
                return db.Sefer.Where(x => x.SeferYonu.StartsWith(nrdn)).ToList();
            }
        }

        public List<Sefer> GetSeferlerByEndWith(string nry)
        {
            using (Context db = new Context())
            {
                return db.Sefer.Where(x => x.SeferYonu.EndsWith(nry)).ToList();
            }
        }
    }
}
