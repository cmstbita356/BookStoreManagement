using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    class StockBLL
    {
        public static int CountStock()
        {
            return StockDAL.CountStock();
        }

        public static List<StockDTO> GetStock()
        {
            return StockDAL.GetStock();
        }

        public static bool Add(StockDTO entry)
        {
            return StockDAL.Add(entry);
        }

        public static bool Delete(string entryId)
        {
            return StockDAL.Delete(entryId);
        }

        public static bool Import(int amount, string entryID)
        {
            return StockDAL.Import(amount, entryID);
        }

        public static bool Edit(StockDTO entry)
        {
            return StockDAL.Edit(entry);
        }
    }
}
