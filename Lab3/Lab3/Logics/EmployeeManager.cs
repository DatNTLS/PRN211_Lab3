using Lab3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Logics
{
    public class EmployeeManager
    {
        public List<Employee> GetAllEmployees()
        {
            using (var context = new NorthwindContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
