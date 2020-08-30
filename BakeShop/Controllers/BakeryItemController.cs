using BakeShop.Data.interfaces;
using BakeShop.Data.Models;
using BakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Controllers
{
    public class BakeryItemController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBakeryItemRepository _bakeryitemRepository;
        public BakeryItemController(ICategoryRepository categoryRepository, IBakeryItemRepository bakeryItemRepository)
        {
            _categoryRepository = categoryRepository;
            _bakeryitemRepository = bakeryItemRepository;
        }

        // creating different section based on category
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<BakeryItem> bakeryitems;

            string currentCategory = string.Empty;
            if(string.IsNullOrEmpty(category))
            {
                bakeryitems = _bakeryitemRepository.BakeryItems.OrderBy(n => n.CategoryId);
                currentCategory = "All Items";
            }
            else
            {
                if(string.Equals("Cake",_category,StringComparison.OrdinalIgnoreCase))
                {
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Cake")).OrderBy(p => p.Name);
                }
                else if(string.Equals("Cookie", _category, StringComparison.OrdinalIgnoreCase))
                {
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Cookie")).OrderBy(p => p.Name);
                }
                else if(string.Equals("Cupcake",_category,StringComparison.OrdinalIgnoreCase))
                {
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Cupcake")).OrderBy(p => p.Name);
                }
                else if (string.Equals("Bread", _category, StringComparison.OrdinalIgnoreCase))
                {
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Bread")).OrderBy(p => p.Name);
                }
                else if (string.Equals("Pie", _category, StringComparison.OrdinalIgnoreCase))
                {
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Pie")).OrderBy(p => p.Name);
                }
                else
                    bakeryitems = _bakeryitemRepository.BakeryItems.Where(p => p.Category.CategoryName.Equals("Doughnut")).OrderBy(p => p.Name);

                currentCategory = _category;
            }
            var bakeryitemListViewModel = new BakeryItemListViewModel
            {
                BakeryItems = bakeryitems,
                CurrentCategory = currentCategory
            };
            return View(bakeryitemListViewModel);
        }

        public ViewResult Details(int bakeryItemId)
        {
            var bakeryitem = _bakeryitemRepository.BakeryItems.FirstOrDefault(d => d.BakeryItemId == bakeryItemId);

            if (bakeryitem == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(bakeryitem);
        }
    }
}
