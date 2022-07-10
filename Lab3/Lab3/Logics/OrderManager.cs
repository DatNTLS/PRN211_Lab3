using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Logics
{
    public class OrderManager
    {
        public List<Order> GetAllOrders(int EmployeeId, int Offset, int Count)
        {
            using (var context = new NorthwindContext())
            {
                if (EmployeeId == 0)
                {
                    return context.Orders.Skip(Offset - 1).Take(Count).ToList();
                }
                else
                {
                    return context.Orders.Where(x => x.EmployeeId == EmployeeId).Skip(Offset - 1).Take(Count).ToList();
                }
            }
        }

        public int GetNumberOfOrders(int EmployeeId)
        {
            using (var context = new NorthwindContext())
            {
                if (EmployeeId == 0)
                {
                    return context.Orders.Count();
                }
                else
                {
                    return context.Orders.Where(x => x.EmployeeId == EmployeeId).Count();
                }
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var context = new NorthwindContext())
            {
                return context.Orders.ToList();
            }
        }
    }
}
