using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;


namespace Project_BookstoreManagement.BLL
{
    class EmloyeeBLL
    {
        public static int CountEmpl()
        {
            return EmployeeDAL.CountEmpl();
        }

        public static List<EmployeeDTO> GetEmpl()
        {
            return EmployeeDAL.GetEmpl();
        }

        public static bool Add(EmployeeDTO entry)
        {
            return EmployeeDAL.Add(entry);
        }

        public static bool Delete(string entryID)
        {
            return EmployeeDAL.Delete(entryID);
        }

        public static bool Edit(EmployeeDTO entry)
        {
            return EmployeeDAL.Edit(entry);
        }

        public static bool ResetPassword(string entryID)
        {
            return EmployeeDAL.ResetPassword(entryID);
        }

        public static EmployeeDTO CheckLogin(string username, string matkhau)
        {
            return EmployeeDAL.CheckLogin(username, matkhau);
        }

        public static bool ChangePassword(string newpass, string entryID)
        {
            return EmployeeDAL.ChangePassword(newpass, entryID);
        }

        public static List<EmployeeDTO> GetEmplByPosition()
        {
            return EmployeeDAL.GetEmplByPosition();
        }
    }
}
