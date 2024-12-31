using System;
using System.Collections.Generic;
using System.Linq;
using shopapp.Models;  
namespace shopapp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category> {
                new Category { CategoryId = 1, Name = "Electronics", Description = "Various electronic items." },
                new Category { CategoryId = 2, Name = "Books", Description = "A variety of books." },  new Category { CategoryId = 3, Name = "Tv's", Description = "Various electronic items." },  new Category { CategoryId = 4, Name = "Pc'", Description = "Various electronic items." }
            };
        }

        public static List<Category> Categories
        {
            get { return _categories; }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategory(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
