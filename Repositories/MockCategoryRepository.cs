﻿using WebBanHangPhongDien.Models;

namespace WebBanHangPhongDien.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;

        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
        {
            new Category { Id = 1, Name = "Laptop" },
            new Category { Id = 2, Name = "Desktop" },
            new Category {Id = 3, Name = "Iphone"},
            // Thêm các category khác
        };
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
