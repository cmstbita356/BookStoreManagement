using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;


namespace Project_BookstoreManagement.BLL
{
    class VendorBLL
    {
        public static int CountVendor()
        {
            return VendorDAL.CountVendor();
        }

        public static List<VendorDTO> GetVendor()
        {
            return VendorDAL.GetVendor();
        }

        public static bool Add(VendorDTO entry)
        {
            return VendorDAL.Add(entry);
        }

        public static bool Delete(string entryID)
        {
            return VendorDAL.Delete(entryID);
        }

        public static bool Edit(VendorDTO entry)
        {
            return VendorDAL.Edit(entry);
        }
    }
}
