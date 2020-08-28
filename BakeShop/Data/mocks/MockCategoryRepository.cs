using BakeShop.Data.interfaces;
using BakeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Data.mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Cake", Description = "Cake is a form of sweet food made from flour, sugar, and other ingredients."},
                    new Category{CategoryName = "Cookie", Description="cookie is a baked or cooked food that is typically small, flat and sweet."},
                    new Category{CategoryName="Bread", Description="Bread is a staple food prepared from a dough of flour and water, usually by baking."},
                    new Category{CategoryName="Doughnut", Description="doughnut or donut is a type of fried dough confection or dessert food."},
                    new Category{CategoryName="Pie", Description="pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients."},
                    new Category{CategoryName="CupCake", Description="A cupcake is a small cake designed to serve one person, which may be baked in a small thin paper or aluminum cup."}
                };
            }

        }
    }
}
