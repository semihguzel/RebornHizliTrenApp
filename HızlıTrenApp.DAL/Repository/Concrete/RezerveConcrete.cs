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
	public class RezerveConcrete
	{		
		public IRepository<RezerveBilet> _rezerveRepository;
		public DbContext _dbContext;

		public RezerveConcrete()
		{
			_dbContext = new Context();
			_rezerveRepository = new EFRepository<RezerveBilet>(_dbContext);
		}
		public List<RezerveBilet> RezerveBiletListesi()
		{
			return _rezerveRepository.GetAll().ToList();
		}
		public object GelenRezerveBilet(string pnrNo, string soyad)
		{
			return _rezerveRepository.GetAll().Where(x => x.RezerveAlinanBilet.BiletinBilgisi.BilgininBileti.PNRNo == pnrNo && x.RezerveAlanMusteri.Soyad == soyad && x.IsBought != true).Select(x => new
			{
				BiletId = x.RezerveAlinanBilet.BiletID,
				RezerveTarihi = x.RezerveTarihi,
				AdSoyad = x.RezerveAlanMusteri.Ad + " " + x.RezerveAlanMusteri.Soyad,
				SeferYonu = x.RezerveAlinanBilet.BiletinBilgisi.SeferinBileti.SaatinSeferi.SeferYonu,
				SeferTarihi = x.RezerveAlinanBilet.BiletinBilgisi.SeferTarihi,
				SeferSaati = x.RezerveAlinanBilet.BiletinBilgisi.SeferinBileti.SeferinSaati.SeferSaatBilgisi,
				KoltukNo = x.RezerveAlinanBilet.BiletinBilgisi.KoltukNo,
				BiletFiyati = x.RezerveAlinanBilet.BiletinBilgisi.BiletFiyati
			}
			).FirstOrDefault();
		}
		public RezerveBilet GetBiletById(int id)
		{
			return _rezerveRepository.GetAll().FirstOrDefault(x => x.BiletID == id);
		}
	}
}
