using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeService
    {
        public static List<NHANVIEN> GetAllEmployees()
        {
            using (var context = new EmployeeDBcontext())
            {
                return context.NHANVIENs.ToList();
            }
        }
        public static NHANVIEN FindByID(string id)
        {
            using (EmployeeDBcontext db = new EmployeeDBcontext())
            {
                return db.NHANVIENs.FirstOrDefault(n => n.ID == id);
            }
        }
        public static void AddEmployee(NHANVIEN employee)
        {
            using (EmployeeDBcontext db = new EmployeeDBcontext())
            {
                db.NHANVIENs.Add(employee);
                db.SaveChanges();
            }
        }
        public static void UpdateEmployee(NHANVIEN employee)
        {
            using (EmployeeDBcontext db = new EmployeeDBcontext())
            {
                var existingEmployee = db.NHANVIENs.FirstOrDefault(n => n.ID == employee.ID);
                if (existingEmployee != null)
                {
                    existingEmployee.HoTen = employee.HoTen;
                    existingEmployee.SoLanXN = employee.SoLanXN;
                    existingEmployee.AmTinh = employee.AmTinh;
                    existingEmployee.MaCty = employee.MaCty;
                    db.SaveChanges();
                }
            }
        }
    }
}
