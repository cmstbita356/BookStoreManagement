using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.BLL
{
    public class DamagedBookBLL
    {
        public static int CountDmgBook()
        {
            return DamagedBookDAL.CountDmgBook();
        }
        public static List<DamagedBookDTO> GetDmgBook()
        {
            return DamagedBookDAL.GetDmgBook();
        }
        public static bool Add(DamagedBookDTO entry)
        {
            return DamagedBookDAL.Add(entry);
        }

        public static bool Edit(DamagedBookDTO entry)
        {
            return DamagedBookDAL.Edit(entry);
        }

        public static bool Delete(string entryID)
        {
            return DamagedBookDAL.Delete(entryID);
        }

        public static bool Liquidate(string entryId, int amount)
        {
            return DamagedBookDAL.Liquidate(entryId, amount);
        }

        public static bool Reset()
        {
            return DamagedBookDAL.Reset();
        }
        public static DamagedBookDTO GetBookById(string entryId)
        {
            return DamagedBookDAL.GetBookById(entryId);
        }
    }
}
