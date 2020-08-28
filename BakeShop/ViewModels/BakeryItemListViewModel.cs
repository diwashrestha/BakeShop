using BakeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.ViewModels
{
    public class BakeryItemListViewModel
    {
        public IEnumerable<BakeryItem> BakeryItems { get; set; }
        public string CurrentCategory { get; set; }
    }
}
