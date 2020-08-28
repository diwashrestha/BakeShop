using BakeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.interfaces
{
    public interface IBakeryItemRepository
    {
        IEnumerable<BakeryItem> BakeryItems { get;  }
        IEnumerable<BakeryItem> PreferredBakeryItems { get; }
        BakeryItem GetBakeryItemById(int BakeryItemId);

    }
}
