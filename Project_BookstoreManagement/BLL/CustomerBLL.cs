using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using Project_BookstoreManagement.DAL;

namespace Project_BookstoreManagement.BLL
{
    class CustomerBLL
    {
        public static int CountCustomer()
        {
            return CustomerDAL.CountCustomer();
        }
        public static List<CustomerDTO> GetCustomer()
        {
            return CustomerDAL.GetCustomer();
        }
        public static bool Delete(string entryID)
        {
            return CustomerDAL.Delete(entryID);
        }
        public static bool Add(CustomerDTO dto)
        {
            return CustomerDAL.Add(dto);
        }
        public static bool Edit(CustomerDTO dto)
        {
            return CustomerDAL.Edit(dto);
        }

        public static List<CustomerDTO> GetCustomerByID(string entryId)
        {
            return CustomerDAL.GetCustomerByID(entryId);
        }
    }
}
