using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TEOAG.API.Data;
using TEOAG.API.Models;

namespace TEOAG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> get()
        {
            return _context.Products;
        }

        [HttpGet("{id}")]
        public Product get(int id)
        {
            return _context.Products.FirstOrDefault(pr => pr.Id == id);
            
        }

        [HttpPost]
        public IEnumerable<Product> post(Product product)
        {
            _context.Products.Add(product);
            if(_context.SaveChanges() > 0 )
                return _context.Products;
            else
                throw new Exception("Você não conseguiu adicionar um produto.");
        }

        [HttpPut("{id}")]
        public Product put(int id, Product product)
        {
           if (product.Id != id) throw new Exception("Você está tentando atualizar o produto errado.");

            _context.Update(product);
            if(_context.SaveChanges() > 0 )
            return _context.Products.FirstOrDefault(pr => pr.Id == id);
            else
                return new Product();
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(pr => pr.Id == id);
            if (product == null)
            throw new Exception("Você está tentando deletar um produto inexistente.");

            _context.Remove(product);

            return _context.SaveChanges() > 0;
        }
    }
}
