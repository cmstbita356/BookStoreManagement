using AutoMapper;
using Project_BookstoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DAL
{
    public class PositionDAL
    {
        public static List<PositionDTO> GetPos()
        {
            List<PositionDTO> result = new List<PositionDTO>();
            db_hieusachEntities db = new db_hieusachEntities();
            var data = from sp in db.Positions
                       where sp.Status == true
                       select sp;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Position, PositionDTO>());
            var mapper = new Mapper(config);
            foreach (Position pos in data)
            {
                
                PositionDTO dto = mapper.Map<PositionDTO>(pos);

                result.Add(dto);
            }

            return result;
        }
    }
}
