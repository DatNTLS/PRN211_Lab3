using Lab3.Logics;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult List(int Id, int Page)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            ViewBag.Employees = employeeManager.GetAllEmployees();

            if (Page <= 0)
                Page = 1;
            int PageSize = 15;

            OrderManager orderManager = new OrderManager();
            ViewBag.Orders = orderManager.GetAllOrders(Id, (Page - 1) * PageSize + 1, PageSize);

            CustomerManager customerManager = new CustomerManager();
            ViewBag.Customers = customerManager.GetAllCustomers();

            int TotalOrder = orderManager.GetNumberOfOrders(Id);
            int TotalPage = TotalOrder / PageSize;

            if (TotalOrder % PageSize != 0)
            {
                TotalPage++;
            }

            ViewData["TotalPage"] = TotalPage;
            ViewData["CurrentPage"] = Page;
            ViewData["CurrentEmployee"] = Id;
            //return View(orders);
            return View("Views/Index.cshtml");
        }

        //public IActionResult List()
        //{
        //    EmployeeManager employeeManager = new EmployeeManager();
        //    ViewBag.Employees = employeeManager.GetAllEmployees();

        //    OrderManager orderManager = new OrderManager();
        //    ViewBag.Orders = orderManager.GetAllOrders();
        //    return View("Views/Index.cshtml");
        //}

    }
}
