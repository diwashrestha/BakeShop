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
    public class ShoppingCartController: Controller
    {
        private readonly IBakeryItemRepository _bakeryItemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBakeryItemRepository bakeryItemRepository, ShoppingCart shoppingCart)
        {
            _bakeryItemRepository = bakeryItemRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddtoShoppingCart(int bakeryitemid)
        {
            var selectedBakeryItem = _bakeryItemRepository
                .BakeryItems.FirstOrDefault(p => p.BakeryItemId == bakeryitemid);
            if(selectedBakeryItem != null)
            {
                _shoppingCart.AddToCart(selectedBakeryItem,1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromshoppingCart(int bakeryitemId)
        {
            var selectedBakeryItem = _bakeryItemRepository
                .BakeryItems.FirstOrDefault(p => p.BakeryItemId == bakeryitemId);
            if(selectedBakeryItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedBakeryItem);
            }
            return RedirectToAction("Index");
        }
    }
}
