using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Main dishes", Description="The main meal for your order"},
                new Category{CategoryId=2, CategoryName="Appetizers", Description="The appetizer for your order"},
                new Category{CategoryId=3, CategoryName="Desserts", Description="The dessert for your order"},
                new Category{CategoryId=4, CategoryName="Drinks", Description="The drink for your order"}
            };
    }
}
