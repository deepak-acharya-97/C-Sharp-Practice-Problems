using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Products> _products = new List<Products>(new[] {
            new Products() { ID=1, Name="Varun Naidu" },
            new Products() { ID=2, Name="Maria Naggaga" },
            new Products() { ID=3, Name="Scott" }
        });

        [HttpGet]
        public List<Products> Get() => _products;
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Products = _products.SingleOrDefault(p => p.ID == id);
            if (Products == null)
            {
                return NotFound();
            }
            return Ok(Products);
        }
        [HttpPost]
        public void Post([FromBody]Products Products)
        {
            _products.Add(Products);
        }
    }
}