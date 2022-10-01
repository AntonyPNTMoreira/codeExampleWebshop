using Howest.DeVarens.Core.Entities;
using Howest.DeVarens.Web.Areas.Shop.Services.Interfaces;
using Howest.DeVarens.Web.Areas.Shop.ViewModels;
using Howest.DeVarens.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Howest.DeVarens.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class ShoppingCartController : Controller
    {
        private readonly WebshopContext _webshopContext;
        private readonly ISessionService _sessionService;

        public ShoppingCartController(WebshopContext webshopContext, ISessionService sessionService)
        {
            _webshopContext = webshopContext;
            _sessionService = sessionService;
        }

        public async Task<IActionResult> AddItem(Guid id)
        {
            var product = await _webshopContext.Products
                .Include(p => p.Media)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                _sessionService.AddProductToShoppingcart(product);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Index()
        {
            var shoppingcartItems = _sessionService.GetProducts();
            return View(shoppingcartItems);
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            var order = new Order
            {
                //OrderItems = _sessionService.GetProducts(),
                ShippingDate = DateTime.Now.AddDays(3),
                IsOpen = true
            };
            _webshopContext.Orders
                .Add(order);
            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                TempData["Error"] = "Kan product niet aanmaken.";
                return RedirectToAction("Create");
            }
            return View();
        }
    }
}
