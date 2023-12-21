using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class ImportDetailDAL
    {
        public static int CountImpDetail()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            int numdetails = (from hd in data.ImportDetails
                         select hd).Count();

            return numdetails;
        }

        public static List<ImportDetailDTO> GetImpDetail()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listCTHD = from hd in data.ImportDetails
                           where hd.Status == true
                           select hd;

            List<ImportDetailDTO> result = new List<ImportDetailDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ImportDetail, ImportDetailDTO>());
            var mapper = new Mapper(config);
            foreach (ImportDetail item in listCTHD)
            {
                ImportDetailDTO newhd = mapper.Map<ImportDetailDTO>(item);

                result.Add(newhd);
            }
            return result;
        }

        public static bool Add(ImportDetailDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ImportDetailDTO, ImportDetail>());
            var mapper = new Mapper(config);
            ImportDetail newhd = mapper.Map<ImportDetail>(entry);

            data.ImportDetails.Add(newhd);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID, string entryId2)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            ImportDetail target = (from hd in data.ImportDetails
                                 where hd.ImportId == entryID.Trim()
                                 && hd.BookId == entryId2.Trim()
                                 select hd).SingleOrDefault();

            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(ImportDetailDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            ImportDetail target = (from hd in data.ImportDetails
                                 where hd.ImportId == entry.ImportId.Trim()
                                 && hd.BookId == entry.BookId.Trim()
                                 select hd).SingleOrDefault();

            target.BookQuantity = entry.BookQuantity;
            target.UnitCost = entry.UnitCost;
            return data.SaveChanges() > 0;
        }

        public static List<ImportDetailDTO> GetImpDetailByImport(string entryId)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listCTHD = from hd in data.ImportDetails
                           where hd.Status == true && hd.ImportId == entryId
                           select hd;

            List<ImportDetailDTO> result = new List<ImportDetailDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ImportDetail, ImportDetailDTO>());
            var mapper = new Mapper(config);
            foreach (ImportDetail item in listCTHD)
            {
               
                ImportDetailDTO newhd = mapper.Map<ImportDetailDTO>(item);

                result.Add(newhd);
            }
            return result;
        }
    }
}
