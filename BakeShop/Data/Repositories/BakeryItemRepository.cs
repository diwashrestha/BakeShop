using BakeShop.Data.interfaces;
using BakeShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.Repositories
{
    public class BakeryItemRepository : IBakeryItemRepository
    {
        private readonly AppDbContext _appDbContext;
        public BakeryItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<BakeryItem> BakeryItems => _appDbContext.BakeryItems.Include(c => c.Category);

        public IEnumerable<BakeryItem> PreferredBakeryItems => _appDbContext.BakeryItems.Where(p => p.IsPreferredBakeryitem).Include(c => c.Category);

        public BakeryItem GetBakeryItemById(int bakeryitemId) => _appDbContext.BakeryItems.FirstOrDefault(p => p.BakeryItemId == bakeryitemId);

    }
}
