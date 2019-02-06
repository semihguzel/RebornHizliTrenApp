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
    public class BiletBilgiDal
    {
        private IRepository<BiletBilgi> _biletBilgiRepository;
        private DbContext _dbContext;

        public BiletBilgiDal()
        {
            _dbContext = new Context();
            _biletBilgiRepository = new EFRepository<BiletBilgi>(_dbContext);
        }
        public List<BiletBilgi> GetByDate(DateTime dateTime)
        {
            using (Context db = new Context())
            {
                return db.BiletBilgileri.Where(x => x.SeferTarihi == dateTime).ToList();
            }
        }

        public bool IsDateCreated(DateTime date,int seferId,int saatId)
        {
            string temp = date.ToShortDateString();
            bool varMi = false;
            List<DateTime> dateList = _biletBilgiRepository.GetAll().Where(x => x.SeferSeferSaatID == saatId).Select(x => x.SeferTarihi).ToList();
            foreach (var item in dateList)
            {
                if (item.ToShortDateString() == temp)
                {
                    varMi = true;
                    break;
                }
                else
                    continue;
            }
            if (varMi)
                return true;
            else
                return false;

        }
        
        SeferlerSeferSaatleriDal sssd = new SeferlerSeferSaatleriDal();
        public List<BiletBilgi> TicketList()
        {
            return _dbContext.Set<BiletBilgi>().ToList();
        }

        public List<BiletBilgi> BusinessTickets()
        {
            return _biletBilgiRepository.GetAll().Where(x => x.KoltukNo.Contains("B")).ToList();
        }

        public List<BiletBilgi> EconomyTickets()
        {
            return _biletBilgiRepository.GetAll().Where(x => x.KoltukNo.Contains("E")).ToList();
        }

        public List<BiletBilgi> BusinessWomanTickets(int seferID, int seferSaatID, DateTime seferTarihi)
        {
            int seferlerSaatlerID = sssd.GetBySeferIdAndSaatId(seferID, seferSaatID);
            List<BiletBilgi> biletListesi = _biletBilgiRepository.GetAll().Where(x => !x.MusterininBileti.Cinsiyet && x.KoltukNo.StartsWith("B") && x.SeferSeferSaatID == seferlerSaatlerID).ToList();
            List<BiletBilgi> tarihtekiBiletler = new List<BiletBilgi>();
            foreach (BiletBilgi item in biletListesi)
            {
                if (item.SeferTarihi.Date == seferTarihi.Date)
                {
                    tarihtekiBiletler.Add(item);
                }
            }
            return tarihtekiBiletler;
        }

        public List<BiletBilgi> BusinessManTickets(int seferID, int seferSaatID,DateTime seferTarihi)
        {
            int seferlerSaatlerID = sssd.GetBySeferIdAndSaatId(seferID, seferSaatID);
            List<BiletBilgi> biletListesi = _biletBilgiRepository.GetAll().Where(x => x.MusterininBileti.Cinsiyet && x.KoltukNo.StartsWith("B") && x.SeferSeferSaatID == seferlerSaatlerID).ToList();
            List<BiletBilgi> tarihtekiBiletler = new List<BiletBilgi>();
            foreach (BiletBilgi item in biletListesi)
            {
                if(item.SeferTarihi.Date == seferTarihi.Date)
                {
                    tarihtekiBiletler.Add(item);
                }
            }
            return tarihtekiBiletler;
        }

        public List<BiletBilgi> EconomyWomanTickets(int seferID, int seferSaatID, DateTime seferTarihi)
        {
            int seferlerSaatlerID = sssd.GetBySeferIdAndSaatId(seferID, seferSaatID);
            List<BiletBilgi> biletListesi = _biletBilgiRepository.GetAll().Where(x => !x.MusterininBileti.Cinsiyet && x.KoltukNo.StartsWith("E") && x.SeferSeferSaatID == seferlerSaatlerID).ToList();
            List<BiletBilgi> tarihtekiBiletler = new List<BiletBilgi>();
            foreach (BiletBilgi item in biletListesi)
            {
                if (item.SeferTarihi.Date == seferTarihi.Date)
                {
                    tarihtekiBiletler.Add(item);
                }
            }
            return tarihtekiBiletler;
        }

        public List<BiletBilgi> EconomyManTickets(int seferID, int seferSaatID, DateTime seferTarihi)
        {
            int seferlerSaatlerID = sssd.GetBySeferIdAndSaatId(seferID, seferSaatID);
            List<BiletBilgi> biletListesi = _biletBilgiRepository.GetAll().Where(x => x.MusterininBileti.Cinsiyet && x.KoltukNo.StartsWith("E") && x.SeferSeferSaatID == seferlerSaatlerID).ToList();
            List<BiletBilgi> tarihtekiBiletler = new List<BiletBilgi>();
            foreach (BiletBilgi item in biletListesi)
            {
                if (item.SeferTarihi.Date == seferTarihi.Date)
                {
                    tarihtekiBiletler.Add(item);
                }
            }
            return tarihtekiBiletler;
        }

    }
}
