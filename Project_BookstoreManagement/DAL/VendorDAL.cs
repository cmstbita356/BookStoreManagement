using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class VendorDAL
    {
        public static int CountVendor()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var numven = (from ncc in data.Vendors
                         select ncc).Count();

            return numven;
        }

        public static List<VendorDTO> GetVendor()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listNCC = from ncc in data.Vendors
                          where ncc.Status == true
                          select ncc;

            List<VendorDTO> result = new List<VendorDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vendor, VendorDTO>());
            var mapper = new Mapper(config);
            foreach (Vendor item in listNCC)
            {
                
                VendorDTO newncc = mapper.Map<VendorDTO>(item);

                result.Add(newncc);
            }
            return result;
        }

        public static bool Add(VendorDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VendorDTO, Vendor>());
            var mapper = new Mapper(config);
            Vendor newncc = mapper.Map<Vendor>(entry);

            data.Vendors.Add(newncc);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Vendor target = (from ncc in data.Vendors
                                 where ncc.VendorId == entryID.Trim()
                                 select ncc).SingleOrDefault();

            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(VendorDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Vendor target = (from ncc in data.Vendors
                                 where ncc.VendorId == entry.VendorId.Trim()
                                 select ncc).SingleOrDefault();

            target.VendorName = entry.VendorName;
            target.VendorPhone = entry.VendorPhone;

            return data.SaveChanges() > 0;
        }
    }
}
