using BakeShop.Data.interfaces;
using BakeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.mocks
{
    public class MockBakeryItemRepository:IBakeryItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<BakeryItem> BakeryItems
        {
            get
            {
                return new List<BakeryItem>
                {
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cup Cake",
                        Price = 6.75M, ShortDescription="Cup Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best Cupcake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Black Forest Cake",
                        Price = 22.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Doughnut",
                        Price = 7.00M, ShortDescription="Doughnut made with Chocolate",
                        Longdescription = "Chocolate cake is best Doughnut.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cookie",
                        Price = 10.75M, ShortDescription="Cookie made with Chocolate",
                        Longdescription = "Chocolate cookie is best cookie.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Cream Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    },
                    new BakeryItem
                    {
                        Name = "Chocolate Cake",
                        Price = 12.75M, ShortDescription="Cake made with Chocolate",
                        Longdescription = "Chocolate cake is best cake.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl="",
                        InStock = true,
                        IsPreferredBakeryitem = true,
                        ImageThumbnailUrl = ""
                    }
                };
            }
        }
        public IEnumerable<BakeryItem> PreferredBakeryItems { get; }
        public BakeryItem GetBakeryItemById(int bakeryitemId)
        {
            throw new NotImplementedException();
        }
    }
}
