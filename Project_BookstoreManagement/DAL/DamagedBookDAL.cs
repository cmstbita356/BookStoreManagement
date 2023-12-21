using AutoMapper;
using AxShockwaveFlashObjects;
using Project_BookstoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DAL
{
    public class DamagedBookDAL
    {
        public static int CountDmgBook()
        {
            db_hieusachEntities db = new db_hieusachEntities();
            int quantity = (from sp in db.DamagedBooks
                            select sp).Count();

            return quantity;
        }

        public static List<DamagedBookDTO> GetDmgBook()
        {
            List<DamagedBookDTO> result = new List<DamagedBookDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.DamagedBooks
                       where sp.Status == true
                       select sp;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DamagedBook, DamagedBookDTO>());
            var mapper = new Mapper(config);
            foreach (DamagedBook item in data)
            { 
                DamagedBookDTO dto = mapper.Map<DamagedBookDTO>(item);

                result.Add(dto);
            }

            return result;
        }

        public static bool Add(DamagedBookDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DamagedBookDTO, Book>());
            var mapper = new Mapper(config);
            DamagedBook newSP = mapper.Map<DamagedBook>(entry);

            data.DamagedBooks.Add(newSP);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            DamagedBook target = (from sp in data.DamagedBooks
                           where sp.BookId == entryID.Trim()
                           select sp).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Liquidate(string entryId, int amount)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            DamagedBook target = (from sp in data.DamagedBooks
                           where sp.BookId == entryId.Trim()
                           select sp).SingleOrDefault();

            if((target.Liquidated + amount) <= target.DamagedTotal)
            {
                target.Liquidated += amount;
            }

            return data.SaveChanges() > 0;
        }

        public static bool Reset()
        {
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.DamagedBooks
                       where sp.Status == true
                       select sp;

            foreach (DamagedBook dmgbook in data)
            {
                dmgbook.DamagedQuantity = 0;
                dmgbook.DamagedTotal = 0;
                dmgbook.Status = true;
            }

            return db.SaveChanges() > 0;
        }

        public static bool Edit(DamagedBookDTO entry)
        {
            db_hieusachEntities db = new db_hieusachEntities();
            DamagedBook data = (from sp in db.DamagedBooks
                         where sp.Status == true
                         && sp.BookId == entry.BookId.Trim()
                         select sp).SingleOrDefault();
            Book data2 = (from sp in db.Books
                                where sp.Status == true
                                && sp.BookId == entry.BookId.Trim()
                                select sp).SingleOrDefault();

            data.DamagedQuantity += entry.DamagedQuantity;
            data.DamagedTotal += data2.BookPrice * entry.DamagedQuantity;
            return db.SaveChanges() > 0;
        }

        public static DamagedBookDTO GetBookById(string entryId)
        {
            db_hieusachEntities db = new db_hieusachEntities();
            DamagedBook data = (from sp in db.DamagedBooks
                         where sp.Status == true
                         && sp.BookId == entryId
                         select sp).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DamagedBook, DamagedBookDTO>());
            var mapper = new Mapper(config);

            DamagedBookDTO result = mapper.Map<DamagedBookDTO>(data);

            return result;
        }
    }
}
