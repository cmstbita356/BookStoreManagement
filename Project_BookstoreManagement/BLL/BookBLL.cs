using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    class BookBLL
    {
        public static int CountBook()
        {
            return BookDAL.CountBook();
        }
        public static List<BookDTO> GetBook()
        {
            return BookDAL.GetBook();
        }
        //public static List<SanPhamDTO> getProductByType(string lsp)
        //{
        //    return BookDAL.getProductByType(lsp);
        //}
        public static bool Add(BookDTO entry)
        {
            return BookDAL.Add(entry);
        }
    
        public static bool Delete(string entryID)
        {
            return BookDAL.Delete(entryID);
        }

        public static bool Edit(BookDTO entry)
        {
            return BookDAL.Edit(entry);
        }

        public static List<BookDTO> GetBookByName(string entryId)
        {
            return BookDAL.GetBookByName(entryId);
        }
        public static BookDTO GetBookById(string entryId)
        {
            return BookDAL.GetBookById(entryId);
        }
        //public static bool Import(int amount, string entryID)
        //{
        //    return BookDAL.Import(amount, entryID);
        //}

        //public static List<SanPhamDTO> EF_GetAll()
        //{
        //    return BookDAL.EF_GetAll();
        //}
        //public static List<SanPhamDTO> EF_Price(int a, int b)
        //{
        //    return BookDAL.EF_Price(a, b);
        //}
        //public static List<SanPhamDTO> EF_FindSP(SanPhamDTO sp)
        //{
        //    return BookDAL.EF_FindSP(sp);
        //}
        //public static List<SanPhamDTO> EF_FindLSP(SanPhamDTO sp)
        //{
        //    return BookDAL.EF_FindLSP(sp);
        //}
        //public static List<SanPhamDTO> EF_FindMSP(SanPhamDTO sp)
        //{
        //    return BookDAL.EF_FindMSP(sp);
        //}
        //public static List<SanPhamDTO> EF_GetData(string s)
        //{
        //    return BookDAL.EF_GetData(s);
        //}
        //public static List<SanPhamDTO> EF_GetLsPWithPrice(int a, int b, SanPhamDTO sp)
        //{
        //    return BookDAL.EF_GetLsPWithPrice(a, b, sp);
        //}
    }
}
