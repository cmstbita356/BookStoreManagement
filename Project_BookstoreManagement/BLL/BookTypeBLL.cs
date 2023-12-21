using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    class BookTypeBLL
    {
        public static int CountBookType()
        {
            return BookTypeDAL.CountBookType();
        }
        public static List<BookTypeDTO> GetBookType()
        {
            return BookTypeDAL.GetBookType();
        }

        public static bool Add(BookTypeDTO entry)
        {
            return BookTypeDAL.Add(entry);
        }

        public static bool Delete(string entryID)
        {
            return BookTypeDAL.Delete(entryID);
        }

        public static bool Edit(BookTypeDTO entry)
        {
            return BookTypeDAL.Edit(entry);
        }
    }
}
