using basic_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic_mvc.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Basit bir model örneği oluşturuyoruz
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };
            var order1 = new Order
            {
                Id = 1,
                ProductName = "Book",
                Price = 20,
                Quantity = 1
            };
            var order2 = new Order
            {
                Id = 2,
                ProductName = "Bed",
                Price = 250,
                Quantity = 3
            };

            // ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Order=order1,
               
            };

            return View(viewModel);
        }
    }
}
