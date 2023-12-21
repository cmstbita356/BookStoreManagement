using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.DAL
{
    public class ReceiptDAL
    {
        public static List<ReceiptDTO> EF_GetAll()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var truyvan = from hd in data.Receipts
                          where hd.Status == true
                          select hd;
            List<ReceiptDTO> listKQ = new List<ReceiptDTO>();
            foreach (Receipt hd in truyvan)
            {
                ReceiptDTO dto = new ReceiptDTO();
                dto.ReceiptId = hd.ReceiptId;
                dto.SaleEmployeeId = hd.SaleEmployeeId;
                dto.CustomerId = hd.CustomerId;
                dto.SaleDate = hd.SaleDate;
                dto.ReceiptTotal = (int)hd.ReceiptTotal;
                dto.Status = true;

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static bool EF_AddData(ReceiptDTO dto)
        {
            db_hieusachEntities db = new db_hieusachEntities();
            Receipt ef = new Receipt();
            ef.ReceiptId = dto.ReceiptId;
            ef.SaleEmployeeId = dto.SaleEmployeeId;
            ef.CustomerId = dto.CustomerId;
            ef.SaleDate = dto.SaleDate;
            ef.ReceiptTotal = dto.ReceiptTotal;
            ef.Status = dto.Status;
            db.Receipts.Add(ef);

            return db.SaveChanges() > 0;
        }
        public static string GetMaHD()
        {
            db_hieusachEntities db = new db_hieusachEntities();
            int count = db.Receipts.Count() + 1;
            string result = "R" + count.ToString("000");
            return result;
        }
    }
}
