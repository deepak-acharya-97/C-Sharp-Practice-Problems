using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>(new[] {
            new Product() { ID=1, Name="Anonymous" },
            new Product() { ID=2, Name="Maria Naggaga" },
            new Product() { ID=3, Name="Scott" }
        });
        [HttpGet]
        public List<Product> Get() => _products;
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.SingleOrDefault(p => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _products.Add(product);
        }
    }
}