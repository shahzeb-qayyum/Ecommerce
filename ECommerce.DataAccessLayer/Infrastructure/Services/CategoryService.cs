using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ECommerce.DataAccessLayer.Infrastructure.Services
{
    public class CategoryService : ICategoryService

    {

        private readonly ECommerceDbContext db;
        public CategoryService(ECommerceDbContext context)
        {
            db = context;
        }
        public bool Delete(int Id)
        {
            var cat = db.Categories.Where(cat => cat.Id == Id).FirstOrDefault();
            db.Categories.Remove(cat);
            db.SaveChanges();
            return true;
        }
        public Category GetById(int Id)

        {
            var category = db.Categories.Where(cust => cust.Id == Id).FirstOrDefault();
            return category;
        }
        public List<Category> GetAll()
        {
            var category = db.Categories.ToList();
            return category;
        }
        public Category Insert(Category category)
        {
            db.Add(category);
            db.SaveChanges();
            return category;

        }
        public Category Update(Category category)
        {
            var categoryToUpdate = GetById(category.Id);
            categoryToUpdate.CategoryName = category.CategoryName;
            categoryToUpdate.Description = category.Description;
            categoryToUpdate.image = category.image;
            db.Categories.Update(categoryToUpdate);
            db.SaveChanges();
            return categoryToUpdate;


        }

    }

}
