using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class BookDAL
    {
        public static int CountBook()
        {
            db_hieusachEntities db = new db_hieusachEntities();
            int quantity = (from sp in db.Books
                       select sp).Count();

            return quantity;
        }

        public static List<BookDTO> GetBook()
        {
            List<BookDTO> result = new List<BookDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.Books
                         where sp.Status == true
                         select sp;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);
            foreach (Book item in data)
            {
                BookDTO dto = mapper.Map<BookDTO>(item);

                result.Add(dto);
            }

            return result;
        }

        public static bool Add(BookDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookDTO, Book>());
            var mapper = new Mapper(config);
            Book newSP = mapper.Map<Book>(entry);

            data.Books.Add(newSP);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Book target = (from sp in data.Books
                              where sp.BookId == entryID.Trim()
                              select sp).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(BookDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            Book target = (from sp in data.Books
                              where sp.BookId == entry.BookId.Trim()
                              select sp).SingleOrDefault();
            target.BookName = entry.BookName;
            target.BookType = entry.BookType;
            target.BookAuthor = entry.BookAuthor;
            target.BookPublisher = entry.BookPublisher;
            target.BookPrice = entry.BookPrice;

            return data.SaveChanges() > 0;
        }

        //public static List<BookDTO> GetBookByType(string type)
        //{
        //    List<BookDTO> result = new List<BookDTO>();
        //    db_hieusachEntities db = new db_hieusachEntities();
        //    var v = db.Books.Where(p => p.BookType == type).ToList();
        //    foreach (Book item in v)
        //    {
        //        SanPhamDTO dto = new SanPhamDTO(item.MaSP, item.TenSP, item.DVTinh, (int)item.DonGia, (int)item.SoLuong, item.MaLoai, (bool)item.TrangThai);
        //        result.Add(dto);
        //    }
        //    return result;
        //}

        //public static List<SanPhamDTO> EF_GetLsPWithPrice(int a, int b, SanPhamDTO sanpham)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.DonGia >= a
        //                  where sp.DonGia <= b
        //                  where sp.MaLoai == sanpham.MaLoai
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;

        //}

        //public static bool Import(int amount, string entryID)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    SanPham target = (from sp in data.SanPhams
        //                      where sp.MaSP == entryID.Trim()
        //                      select sp).SingleOrDefault();
        //    target.SoLuong += amount;
        //    return data.SaveChanges() > 0;
        //}

        //public static List<SanPhamDTO> EF_GetAll()
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;
        //}
        //public static List<SanPhamDTO> EF_Price(int a, int b)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.DonGia >= a
        //                  where sp.DonGia <= b
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;
        //}
        //public static List<SanPhamDTO> EF_FindSP(SanPhamDTO sanpham)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.TenSP == sanpham.TenSP
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;
        //}
        //public static List<SanPhamDTO> EF_FindMSP(SanPhamDTO sanpham)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.MaSP == sanpham.MaSP
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;
        //}
        //public static List<SanPhamDTO> EF_FindLSP(SanPhamDTO sanpham)
        //{
        //    QLNSEntities data = new QLNSEntities();
        //    var truyvan = from sp in data.SanPhams
        //                  where sp.MaLoai == sanpham.MaLoai
        //                  where sp.TrangThai == true
        //                  select sp;
        //    List<SanPhamDTO> listKQ = new List<SanPhamDTO>();
        //    foreach (SanPham sp in truyvan)
        //    {
        //        var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
        //        var mapper = new Mapper(config);
        //        SanPhamDTO dto = mapper.Map<SanPhamDTO>(sp);

        //        listKQ.Add(dto);
        //    }
        //    return listKQ;
        //}
        public static List<BookDTO> GetBookByName(string entryId)
        {
            List<BookDTO> result = new List<BookDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.Books
                       where sp.Status == true
                       && sp.BookName == entryId
                       select sp;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);
            foreach (Book item in data)
            {
                BookDTO dto = mapper.Map<BookDTO>(item);

                result.Add(dto);
            }

            return result;
        }

        public static BookDTO GetBookById(string entryId)
        {
            db_hieusachEntities db = new db_hieusachEntities();
            Book data = (from sp in db.Books
                       where sp.Status == true
                       && sp.BookId == entryId
                       select sp).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);

            BookDTO result = mapper.Map<BookDTO>(data);

            return result;
        }
    }
}
