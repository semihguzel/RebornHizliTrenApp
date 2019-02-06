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
	public class SatilanConcrete
	{
		public IRepository<SatilanBilet> _satilanBiletRepository;
		public DbContext _dbContext;

		public SatilanConcrete()
		{
			_dbContext = new Context();
			_satilanBiletRepository = new EFRepository<SatilanBilet>(_dbContext);
		}
	}
}
