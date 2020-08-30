using BakeShop.Data.interfaces;
using BakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeShop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IBakeryItemRepository _bakeryItemRepository;

        public HomeController(IBakeryItemRepository bakeryItemRepository)
        {
            _bakeryItemRepository = bakeryItemRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredBakeryItems = _bakeryItemRepository.PreferredBakeryItems
            };
            return View(homeViewModel);
        }
    }
}
