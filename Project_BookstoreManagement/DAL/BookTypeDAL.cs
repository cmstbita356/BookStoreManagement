using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DTO;
using AutoMapper;

namespace Project_BookstoreManagement.DAL
{
    class BookTypeDAL
    {
        public static int CountBookType()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            int quantity = (from lsp in data.BookTypes
                          select lsp).Count();

            return quantity;
        }

        public static List<BookTypeDTO> GetBookType()
        {
            db_hieusachEntities data = new db_hieusachEntities();
            var listLSP = from lsp in data.BookTypes
                          where lsp.Status == true
                          select lsp;

            List<BookTypeDTO> result = new List<BookTypeDTO>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookType, BookTypeDTO>());
            var mapper = new Mapper(config);
            foreach (BookType item in listLSP)
            {
                BookTypeDTO dto = mapper.Map<BookTypeDTO>(item);

                result.Add(dto);
            }

            return result;
        }

        public static bool Add(BookTypeDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookTypeDTO, BookType>());
            var mapper = new Mapper(config);
            BookType newLSP = mapper.Map<BookType>(entry);

            data.BookTypes.Add(newLSP);
            return data.SaveChanges() > 0;
        }

        public static bool Delete(string entryID)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            BookType target = (from lsp in data.BookTypes
                                  where lsp.TypeId == entryID.Trim()
                                  select lsp).SingleOrDefault();
            target.Status = false;
            return data.SaveChanges() > 0;
        }

        public static bool Edit(BookTypeDTO entry)
        {
            db_hieusachEntities data = new db_hieusachEntities();
            BookType target = (from lsp in data.BookTypes
                                  where lsp.TypeId == entry.TypeId.Trim()
                                  select lsp).SingleOrDefault();
            target.TypeName = entry.TypeName;
            return data.SaveChanges() > 0;
        }
    }
}
