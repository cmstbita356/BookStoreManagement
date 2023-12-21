using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    class ImportDetailBLL
    {
        public static int CountImpDetail()
        {
            return ImportDetailDAL.CountImpDetail();
        }

        public static List<ImportDetailDTO> GetImpDetail()
        {
            return ImportDetailDAL.GetImpDetail();
        }

        public static bool Add(ImportDetailDTO entry)
        {
            return ImportDetailDAL.Add(entry);
        }

        public static bool Delete(string entryID, string entryId2)
        {
            return ImportDetailDAL.Delete(entryID, entryId2);
        }

        public static bool Edit(ImportDetailDTO entry)
        {
            return ImportDetailDAL.Edit(entry);
        }

        public static List<ImportDetailDTO> GetImpDetailByImport(string entryId)
        {
            return ImportDetailDAL.GetImpDetailByImport(entryId);
        }
    }
}
