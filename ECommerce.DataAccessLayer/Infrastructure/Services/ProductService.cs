using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccessLayer.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly ECommerceDbContext db;

        public ProductService(ECommerceDbContext context)
        {
            db = context;
        }
        public bool Delete(int Id)
        {
            var pro = db.Products.Where(pro => pro.Id == Id).FirstOrDefault();
            db.Products.Remove(pro);
            db.SaveChanges();
            return true;
        }

        public List<Product> GetAll()
        {
            var product = db.Products.ToList();
            return product;
        }

        public Product GetById(int Id)
        {
            var product = db.Products.Where(product => Id == Id).FirstOrDefault();
            return product;
        }

        public Product Insert(Product product)
        {
            db.Add(product);
            db.SaveChanges();
            return product;
        }

        public Product Update(Product product)
        {
            var ProductToUpdate = GetById(product.Id);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.ProductDiscription = product.ProductDiscription;
            ProductToUpdate.Discontinued = product.Discontinued;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.CategoryId = product.CategoryId;
            db.Products.Update(ProductToUpdate);
            db.SaveChanges();
            return product;
        }
    }
}
