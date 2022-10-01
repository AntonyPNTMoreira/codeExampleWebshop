using Howest.DeVarens.Core.Entities;
using Howest.DeVarens.Web.Areas.Shop.Services.Interfaces;
using Howest.DeVarens.Web.Areas.Shop.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;

namespace Howest.DeVarens.Web.Areas.Shop.Services
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void AddProductToShoppingcart(Product product)
        {
            var products = new ShoppingcartIndexViewModel();
            products.ShoppingcartItems = new List<ShoppingcartDetailViewModel>();
            int numberOfProducts = 0;


            if (_httpContextAccessor.HttpContext.Session.Keys.Contains("ShopItems"))
            {
                products = JsonConvert
                    .DeserializeObject<ShoppingcartIndexViewModel>(_httpContextAccessor.HttpContext.Session.GetString("ShopItems"));
            }

            //check if product is in shoppingcart
            if (!products.ShoppingcartItems.Any(s => s.ProductId == product.Id))
            {
                products.ShoppingcartItems.Add(new ShoppingcartDetailViewModel
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductMediaPath = product.Media.FirstOrDefault()?.Path ?? "",
                    Quantity = 1,
                    Quantities = Enumerable.Range(1, 10).Select(i => new SelectListItem
                    {
                        Text = i.ToString(),
                        Value = i.ToString(),
                        Selected = true
                    }),
                });
                products.TotalPrice += product.Price;
                _httpContextAccessor.HttpContext.Session.SetString("Products", JsonConvert.SerializeObject(products));
            }
            else
            {
                //product in shoppingcart
                var quantity = products.ShoppingcartItems.FirstOrDefault(p => p.ProductId == product.Id).Quantity += 1;
                products.TotalPrice += product.Price * (quantity - 1);
            }
            //add product list to session
            _httpContextAccessor.HttpContext.Session.SetString("ShopItems", JsonConvert.SerializeObject(products));
            //add to totalnuber of products
            numberOfProducts = products.ShoppingcartItems.Sum(p => p.Quantity);
            _httpContextAccessor.HttpContext.Session.SetInt32("NumberOfProducts", numberOfProducts);
        }

        public ShoppingcartIndexViewModel GetProducts()
        {
            if (!_httpContextAccessor.HttpContext.Session.Keys.Contains("ShopItems"))
            {
                return new ShoppingcartIndexViewModel();
            }
            return JsonConvert
                .DeserializeObject<ShoppingcartIndexViewModel>
                (_httpContextAccessor.HttpContext.Session.GetString("ShopItems")
                );
        }
    }
}