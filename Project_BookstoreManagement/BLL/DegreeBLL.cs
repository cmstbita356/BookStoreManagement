using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_BookstoreManagement.DAL;
using Project_BookstoreManagement.DTO;

namespace Project_BookstoreManagement.BLL
{
    public class DegreeBLL
    {
        public static List<DegreeDTO> GetDeg()
        {
            return DegreeDAL.GetDeg();
        }
    }
}
