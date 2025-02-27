using Microsoft.AspNetCore.Mvc;
using ordersapi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ordersapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> Orders = new List<Order>
        {
            new Order 
            { 
                Id = 1, 
                Name = "Order1", 
                ProductDetails = new List<ProductDetail>
                {
                    new ProductDetail { Product = "Tomato Soup", Quantity = 2, Price = 2M },
                    new ProductDetail { Product = "Nails", Quantity = 1, Price = 3.75M }
                }
            },
            new Order 
            { 
                Id = 2, 
                Name = "Order2", 
                ProductDetails = new List<ProductDetail>
                {
                    new ProductDetail { Product = "Yo-yo", Quantity = 1, Price = 3.75M },
                    new ProductDetail { Product = "XboX", Quantity = 2, Price = 3.75M }
                }
            },
            new Order 
            { 
                Id = 3, 
                Name = "Order3", 
                ProductDetails = new List<ProductDetail>
                {
                    new ProductDetail { Product = "Drum", Quantity = 1, Price = 3.75M },
                    new ProductDetail { Product = "Hammer", Quantity = 1, Price = 16.99M }
                }
            }
        };

        // GET orders
        [HttpGet(Name = "GetOrders")]
        public IEnumerable<Order> Get()
        {
            return Orders;
        }

        // GET orders/5
        [HttpGet("{id}", Name = "GetOrderbyId")]
        public IActionResult Get(int id)
        {
            var order = Orders.FirstOrDefault((p) => p.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        public void AddOrder([FromBody] Order newOrder)
        {

        }
        public void Delete(int id)
        {
        }
    }
}
