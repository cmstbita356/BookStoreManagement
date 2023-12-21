using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using Project_BookstoreManagement.DAL;

namespace Project_BookstoreManagement.BLL
{
    class ReceiptDetailBLL
    {
        public static List<ReceiptDetailDTO> EF_GetAll()
        {
            return ReceiptDetailDAL.EF_GetAll();
        }
        public static bool AddData(ReceiptDetailDTO dto)
        {
            return ReceiptDetailDAL.AddData(dto);
        }
    }
}
