using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TEOAG.API.Models;

namespace TEOAG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TEOAGController : ControllerBase
    {
        public IEnumerable<Product> Products = new List<Product>()
            {
                new Product(1),
                new Product(2),
                new Product(3)
            };

        [HttpGet]
        public IEnumerable<Product> get()
        {
            return Products;
        }

         [HttpGet("{id}")]
        public Product get(int id)
        {
            return Products.FirstOrDefault( pr => pr.Id == id);
        }

        [HttpPost]
        public IEnumerable<Product> post(Product product)
        {
            return Products.Append<Product>(product);
        }

         [HttpPut]
        public Product put(int id, Product product)
        {
            product.Id = product.Id+1;
            return product;
        }

         [HttpDelete]
        public string Delete(int id)
        {
            return $"Method Delete Test id: {id}";
        }
    }
}
