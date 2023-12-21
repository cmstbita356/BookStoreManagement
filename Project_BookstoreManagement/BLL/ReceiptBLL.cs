using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using Project_BookstoreManagement.DAL;

namespace Project_BookstoreManagement.BLL
{
    class ReceiptBLL
    {
        public static List<ReceiptDTO> EF_GetAll()
        {
            return ReceiptDAL.EF_GetAll();
        }
        public static bool EF_AddData(ReceiptDTO dto)
        {
            return ReceiptDAL.EF_AddData(dto);
        }
        public static string GetMaHD()
        {
            return ReceiptDAL.GetMaHD();
        }
    }
}
