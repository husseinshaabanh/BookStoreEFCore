using OnlineBookStoreWithASPNETCore.Contexts;
using OnlineBookStoreWithASPNETCore.Entities;
using OnlineBookStoreWithASPNETCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly OnlineBookStoreDbContext dbContext;
        public CategoryRepository(OnlineBookStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<string> GetCategories()
        {
            try
            {
                var getCategory = dbContext.Categories.Select(C => C.CategoryName).Distinct().ToList();
                return getCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting categories from DB: " + ex.Message);
                return new List<string>();
            }
        }
        public Entities.Category GetOrCreateCategoryByName(string name)
        {
            var category = dbContext.Categories.FirstOrDefault(c => c.CategoryName == name);
            if (category == null)
            {
                category = new Entities.Category { CategoryName = name };
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
            }
            return category;
        }
    }
}
