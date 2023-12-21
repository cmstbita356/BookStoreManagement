using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class ReceiptDetailDAL
    {
        public static List<ReceiptDetailDTO> EF_GetAll()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var truyvan = from ct in data.ReceiptDetails
                          where ct.Status == true
                          select ct;
            List<ReceiptDetailDTO> listKQ = new List<ReceiptDetailDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ReceiptDetail, ReceiptDetailDTO>());
            var mapper = new Mapper(config);
            foreach (ReceiptDetail ct in truyvan)
            {
                
                ReceiptDetailDTO dto = mapper.Map<ReceiptDetailDTO>(ct);

                listKQ.Add(dto);
            }
            return listKQ;
        }
        public static bool AddData(ReceiptDetailDTO dto)
        {
            db_hieusachEntities db = new db_hieusachEntities();
            ReceiptDetail ef = new ReceiptDetail();
            ef.ReceiptId = dto.ReceiptId;
            ef.BookId = dto.BookId;
            ef.Quantity = dto.Quantity;
            ef.Status = dto.Status;
            db.ReceiptDetails.Add(ef);
            db.SaveChanges();
            return true;
        }
    }
}
