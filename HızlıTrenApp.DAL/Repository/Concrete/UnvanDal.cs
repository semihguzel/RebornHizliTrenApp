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
    public class UnvanDal
    {
        private IRepository<Unvan> _unvanRepository;
        private DbContext _dbContext;


        public UnvanDal()
        {
            _dbContext = new Context();
            _unvanRepository = new EFRepository<Unvan>(_dbContext);
        }

        public List<Unvan> GetAll()
        {
            return _unvanRepository.GetAll().ToList();
        }

        public Unvan GetByUnvanID(int id)
        {
            using (Context db=new Context())
            {
                return db.Unvan.FirstOrDefault(x => x.UnvanID == id);
            }
        }

        public void Add(Unvan unvan)
        {
            using (Context db=new Context())
            {
                var addEntity = db.Entry(unvan);
                addEntity.State = EntityState.Added;
                db.SaveChanges();
            }
        }
    }
}
