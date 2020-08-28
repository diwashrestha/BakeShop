using BakeShop.Data.interfaces;
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

        public ViewResult List()
        {
            // ViewBag transfers data only controller to view
            ViewBag.Name = "DotNet, How?";
            BakeryItemListViewModel vm = new BakeryItemListViewModel();
            vm.BakeryItems = _bakeryitemRepository.BakeryItems;
            vm.CurrentCategory = "BakeryItemCategory";

            return View(vm);
        }
    }
}
