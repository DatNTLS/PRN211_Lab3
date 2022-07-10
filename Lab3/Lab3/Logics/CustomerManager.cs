using Lab3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Logics
{
    public class CustomerManager
    {
        public List<Customer> GetAllCustomers()
        {
            using (var context = new NorthwindContext())
            {
                return context.Customers.ToList();
            }
        }
    }
}
