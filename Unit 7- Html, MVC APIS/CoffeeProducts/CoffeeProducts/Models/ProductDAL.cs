﻿namespace CoffeeProducts.Models
{
    public class ProductDAL
    {
        private static ProductDbContext dbContext = new ProductDbContext();

        public static List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public static Product GetById(int id)
        {
            return dbContext.Products.Find(id);
        }

        public static List<Product> GetAllByCategory(string category)
        {
            return dbContext.Products.Where(p => p.Category.ToLower().Trim() == category.ToLower().Trim()).ToList();
        }

        
        public static List<string> GetAllCategories()
        {
            return dbContext.Products.GroupBy(p => p.Category).ToDictionary(x => x.Key, y => y).Keys.ToList();
        }

    }
}
