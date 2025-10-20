using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class CompanyService
    {
        public static List<CONGTY> GetAllCompanies()
        {
            using (var db = new DAL.Entities.EmployeeDBcontext())
            {
                return db.CONGTies.ToList();
            }
        }
    }
}
