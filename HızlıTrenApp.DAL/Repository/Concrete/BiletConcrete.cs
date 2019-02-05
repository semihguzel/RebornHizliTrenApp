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
	public class BiletConcrete
	{
		public IRepository<Bilet> _biletRepository;
		public DbContext _dbContext;

		public BiletConcrete()
		{
			_dbContext = new Context();
			_biletRepository = new EFRepository<Bilet>(_dbContext);
		}
		public List<Bilet> BiletListesi()
		{
			return _biletRepository.GetAll().ToList();
		}
		public object GelenBilet(string pnrNo, string soyad)
		{
			return _biletRepository.GetAll().Where(x => x.BiletinBilgisi.BilgininBileti.PNRNo == pnrNo && x.BiletinBilgisi.MusterininBileti.Soyad == soyad).Select(x => new
			{
				//omer bunu veritabaninda yeni degistirip yolladi ismi farkli :D update database demedik ama zaten bunu c# kisminda entity de degistirdigi icin cekemiyor o yuzden burdan direk patladi simdi calistirsak bu sefer database yi update yap der
				BiletAlimTarihi = x.BiletinBilgisi.AlimTarihi,
				Ad = x.BiletinBilgisi.MusterininBileti.Ad,
				SeferYonu = x.BiletinBilgisi.SeferinBileti.SaatinSeferi.SeferYonu,
				SeferTarihi = x.BiletinBilgisi.SeferTarihi,
				SeferSaati = x.BiletinBilgisi.SeferinBileti.SeferinSaati.SeferSaatBilgisi,
				KoltukNo = x.BiletinBilgisi.KoltukNo,
				BiletFiyati = x.BiletinBilgisi.BiletFiyati
			}
			).FirstOrDefault();
		}
		public Bilet GetBiletById(int id)
		{
			return _biletRepository.GetAll().FirstOrDefault(x => x.BiletID == id);
		}
	}
}
