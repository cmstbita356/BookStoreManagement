using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class CustomerDAL
    {
        public static int CountCustomer()
        {
            db_hieusachEntities db = new db_hieusachEntities();
            int quantity = (from cus in db.Customers
                            select cus).Count();

            return quantity;
        }

        public static List<CustomerDTO> GetCustomer()
        {
            List<CustomerDTO> result = new List<CustomerDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from cus in db.Customers
                       where cus.Status == true
                       select cus;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = new Mapper(config);
            foreach (Customer customer in data)
            { 
                CustomerDTO dto = mapper.Map<CustomerDTO>(customer);

                result.Add(dto);
            }

            return result;
        }

        public static bool Add(CustomerDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>());
            var mapper = new Mapper(config);
            Customer newcus = mapper.Map<Customer>(entry);

            data.Customers.Add(newcus);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Customer target = (from cus in data.Customers
                           where cus.CustomerId == entryID.Trim()
                           select cus).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(CustomerDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Customer target = (from cus in data.Customers
                           where cus.CustomerId == entry.CustomerId.Trim()
                           select cus).SingleOrDefault();
            target.CustomerName = entry.CustomerName;
            target.CustomerPhone = entry.CustomerPhone;
            target.CustomerEmail = entry.CustomerEmail;

            return data.SaveChanges() > 0;
        }

        //public static void EF_Delete(CustomerDTO dto)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    KhachHang kh = (from khachhang in data.KhachHangs
        //                    where khachhang.MaKH == dto.MaKH.Trim()
        //                    select khachhang).FirstOrDefault<KhachHang>();
        //    kh.MaKH = dto.MaKH;
        //    kh.Email = dto.Email;
        //    kh.TenKH = dto.TenKH;
        //    kh.SDT = dto.SDT;
        //    kh.TrangThai = dto.TrangThai;
        //    data.SaveChanges();
        //}
        //public static void EF_AddNew(CustomerDTO dto)
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, KhachHang>());
        //    var mapper = new Mapper(config);
        //    KhachHang kh = mapper.Map<KhachHang>(dto);

        //    QLNSEntities data = new QLNSEntities();
        //    data.KhachHangs.Add(kh);
        //    data.SaveChanges();
        //}
        //public static void EF_Edit(CustomerDTO dto)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    KhachHang kh = (from khachhang in data.KhachHangs
        //                    where khachhang.MaKH == dto.MaKH.Trim()
        //                    select khachhang).SingleOrDefault<KhachHang>();
        //    kh.MaKH = dto.MaKH;
        //    kh.Email = dto.Email;
        //    kh.TenKH = dto.TenKH;
        //    kh.SDT = dto.SDT;
        //    kh.TrangThai = dto.TrangThai;
        //    data.SaveChanges();
        //}
        public static List<CustomerDTO> GetCustomerByID(string entryId)
        {
            List<CustomerDTO> result = new List<CustomerDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from cus in db.Customers
                       where cus.Status == true
                       && cus.CustomerId == entryId
                       select cus;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = new Mapper(config);
            foreach (Customer customer in data)
            {
                CustomerDTO dto = mapper.Map<CustomerDTO>(customer);

                result.Add(dto);
            }

            return result;
        }
    }
}
