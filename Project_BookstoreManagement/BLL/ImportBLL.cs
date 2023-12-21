using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    class ImportBLL
    {
        public static int CountImp()
        {
            return ImportDAL.CountImp();
        }

        public static List<ImportDTO> GetImport()
        {
            return ImportDAL.GetImport();
        }

        public static bool Add(ImportDTO entry)
        {
            return ImportDAL.Add(entry);
        }

        public static bool Delete(string entryID)
        {
            return ImportDAL.Delete(entryID);
        }

        public static bool Edit(ImportDTO entry)
        {
            return ImportDAL.Edit(entry);
        }
    }
}
