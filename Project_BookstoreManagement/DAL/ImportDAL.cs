using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class ImportDAL
    {
        public static int CountImp()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var numimp = (from hd in data.Imports
                         select hd).Count();

            return numimp;
        }

        public static List<ImportDTO> GetImport()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listHD = from hd in data.Imports
                         where hd.Status == true
                         select hd;

            List<ImportDTO> result = new List<ImportDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Import, ImportDTO>());
            var mapper = new Mapper(config);
            foreach (Import item in listHD)
            {
                
                ImportDTO newhd = mapper.Map<ImportDTO>(item);

                result.Add(newhd);
            }
            return result;
        }

        public static bool Add(ImportDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ImportDTO, Import>());
            var mapper = new Mapper(config);
            Import newhd = mapper.Map<Import>(entry);

            data.Imports.Add(newhd);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Import target = (from hd in data.Imports
                                 where hd.ImportId == entryID.Trim()
                                 select hd).SingleOrDefault();

            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(ImportDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Import target = (from hd in data.Imports
                                 where hd.ImportId == entry.ImportId.Trim()
                                 select hd).SingleOrDefault();
            target.EmplId = entry.EmplId;
            target.VendorId = entry.VendorId;
            target.ImportDate = entry.ImportDate;
            target.ImportTotal = entry.ImportTotal;
            return data.SaveChanges() > 0;
        }
    }
}
