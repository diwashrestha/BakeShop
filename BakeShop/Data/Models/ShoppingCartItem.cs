using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public BakeryItem BakeryItem { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
