using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Orderid { get; set; }
        public int BakeryItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual BakeryItem BakeryItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
