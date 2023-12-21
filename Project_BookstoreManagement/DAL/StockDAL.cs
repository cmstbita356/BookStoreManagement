using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class StockDAL
    {
        public static int CountStock()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            int numstock = (from tk in data.Stocks
                          select tk).Count();

            return numstock;
        }

        public static List<StockDTO> GetStock()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listTK = from tk in data.Stocks
                         where tk.Status == true
                         select tk;

            List<StockDTO> result = new List<StockDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Stock, StockDTO>());
            var mapper = new Mapper(config);
            foreach (Stock item in listTK)
            {
                
                StockDTO newtk = mapper.Map<StockDTO>(item);

                result.Add(newtk);
            }
            return result;
        }

        public static bool Add(StockDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StockDTO, Stock>());
            var mapper = new Mapper(config);
            Stock newtk = mapper.Map<Stock>(entry);

            data.Stocks.Add(newtk);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Stock target = (from sp in data.Stocks
                           where sp.BookId == entryID.Trim()
                           select sp).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Import(int amount, string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Stock target = (from sp in data.Stocks
                              where sp.BookId == entryID.Trim()
                              select sp).SingleOrDefault();
            target.BookQuantity += amount;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(StockDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Stock target = (from tk in data.Stocks
                             where tk.BookId == entry.BookId.Trim()
                             select tk).SingleOrDefault();
            target.BookQuantity = entry.BookQuantity;
            return data.SaveChanges() > 0;
        }
    }
}
