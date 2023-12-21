using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class EmployeeDAL
    {
        public static int CountEmpl()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            int emnum = (from nv in data.Employees
                         select nv).Count();

            return emnum;
        }

        public static List<EmployeeDTO> GetEmpl()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listNV = from nv in data.Employees
                         where nv.Status == true
                         select nv;

            List<EmployeeDTO> result = new List<EmployeeDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());
            var mapper = new Mapper(config);
            foreach (Employee em in listNV)
            {
                
                EmployeeDTO dto = mapper.Map<EmployeeDTO>(em);

                result.Add(dto);
            }

            return result;
        }

        public static List<EmployeeDTO> GetEmplByPosition()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listNV = from nv in data.Employees
                         where nv.Status == true
                         && nv.EmplPosition == "QL"
                         select nv;

            List<EmployeeDTO> result = new List<EmployeeDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());
            var mapper = new Mapper(config);
            foreach (Employee em in listNV)
            {

                EmployeeDTO dto = mapper.Map<EmployeeDTO>(em);

                result.Add(dto);
            }

            return result;
        }

        public static bool Add(EmployeeDTO entry)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<EmployeeDTO, Employee>());
            var mapper = new Mapper(config);
            Employee dto = mapper.Map<Employee>(entry);

            db_hieusachEntities data = new db_hieusachEntities();
            data.Employees.Add(dto);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Employee target = (from nv in data.Employees
                          where nv.EmplId == entryID.Trim()
                          select nv).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(EmployeeDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Employee target = (from nv in data.Employees
                               where nv.EmplId == entry.EmplId.Trim()
                               select nv).SingleOrDefault();
            target.EmplName = entry.EmplName;
            target.EmplDegree = entry.EmplDegree;
            target.EmplPosition = entry.EmplPosition;
            target.EmplPhone = entry.EmplPhone;
            target.EmplAddress = entry.EmplAddress;
            target.EmplUsername = entry.EmplUsername;

            return data.SaveChanges() > 0;
        }

        public static bool ResetPassword(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Employee target = (from nv in data.Employees
                               where nv.EmplId == entryID.Trim()
                               select nv).SingleOrDefault();

            target.EmplPassword = "e10adc3949ba59abbe56e057f20f883e"; //123456
            return data.SaveChanges() > 0;
        }

        public static EmployeeDTO CheckLogin(string username, string matkhau)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Employee result = (from nv in data.Employees
                               where username == nv.EmplUsername
                                     && matkhau == nv.EmplPassword
                               select nv).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());
            var mapper = new Mapper(config);
            EmployeeDTO dto = mapper.Map<EmployeeDTO>(result);
            return dto;
        }

        public static bool ChangePassword(string newpass, string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Employee target = (from nv in data.Employees
                               where nv.EmplId == entryID.Trim()
                               select nv).SingleOrDefault();
            target.EmplPassword = newpass;
            return data.SaveChanges() > 0;
        }
    }
}
