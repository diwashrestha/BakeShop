using BakeShop.Data.interfaces;
using BakeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly AppDbContext _appdbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appdbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appdbContext.Categories;
    }
}
