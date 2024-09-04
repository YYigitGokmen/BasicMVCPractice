using BasicMVCPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCPractice.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName ="Doe",
                Email = "john.doe@example.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Product A", Price = 100.00m,Quantity= 5 },
                new Order { Id = 2, ProductName = "Product B", Price = 50.00m ,Quantity= 15},
                new Order { Id = 3, ProductName = "Product C", Price= 75.00m,Quantity= 25 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);


        }


        }
}
