using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductManager
    {
        private readonly ApplicationDbContext _context;

        public ProductManager(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Product> GetAll()
        {
            return _context.Products.Where(x=>!x.IsDeleted).OrderByDescending(x=>x.PublishDate).ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();

        }
        public void Delete(Product product)
        {
            product.IsDeleted = true;
            _context.SaveChanges();

        }
    }
}
