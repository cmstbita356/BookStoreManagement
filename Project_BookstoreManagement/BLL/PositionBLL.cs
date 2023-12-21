using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    public class PositionBLL
    {
        public static List<PositionDTO> GetPos()
        {
            return PositionDAL.GetPos();
        }
    }
}
