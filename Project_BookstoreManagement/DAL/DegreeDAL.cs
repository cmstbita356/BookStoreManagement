using AutoMapper;
using Project_BookstoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DAL
{
    public class DegreeDAL
    {
        public static List<DegreeDTO> GetDeg()
        {
            List<DegreeDTO> result = new List<DegreeDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.Degrees
                       where sp.Status == true
                       select sp;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Degree, DegreeDTO>());
            var mapper = new Mapper(config);
            foreach (Degree pos in data)
            {
                DegreeDTO dto = mapper.Map<DegreeDTO>(pos);

                result.Add(dto);
            }

            return result;
        }
    }
}
