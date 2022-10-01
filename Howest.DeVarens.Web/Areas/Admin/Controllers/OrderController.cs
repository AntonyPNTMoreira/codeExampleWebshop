using Howest.DeVarens.Web.Areas.Admin.Models;
using Howest.DeVarens.Web.Areas.Admin.ViewModels;
using Howest.DeVarens.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Howest.DeVarens.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly WebshopContext _webshopContext;

        public OrderController(WebshopContext webshopContext)
        {
            _webshopContext = webshopContext;
        }
        public async Task<IActionResult> Index(OrderIndexViewModel orderIndexViewModel)
        {
            orderIndexViewModel.Orders
            = await _webshopContext.Orders
            .Where(o => o.DeletionDate == null)
            .Select(o => new OrderDetailViewModel
            {
                Id = o.Id,
                CreationDate = o.CreationDate,
                IsOpen = o.IsOpen,
                ShippingDate = o.ShippingDate,
                DeletionDate = o.DeletionDate,
                UpdateDate = o.UpdateDate
            }).ToListAsync();
            ViewBag.Id = 1;
            return View(orderIndexViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> ShowSelectedOrders(int id)
        {
            OrderIndexViewModel orderIndexViewModel = new OrderIndexViewModel();
            orderIndexViewModel.Orders
            = await _webshopContext.Orders
            .Where(o => o.DeletionDate == null)
            .Select(o => new OrderDetailViewModel
            {
                Id = o.Id,
                CreationDate = o.CreationDate,
                IsOpen = o.IsOpen,
                ShippingDate = o.ShippingDate,
                DeletionDate = o.DeletionDate,
                UpdateDate = o.UpdateDate,
            }).ToListAsync();



            if (id == 2 || id == 3)
            {
                orderIndexViewModel.Orders = orderIndexViewModel.Orders.Where(o => o.IsOpen == (id == 2));
            }
            ViewBag.Id = id;
            return View("Index", orderIndexViewModel);
        }

            public async Task<IActionResult> Details(Guid id)
            {
            var order = await _webshopContext.Orders.Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.Id == id);

            var productsCount = await _webshopContext.OrderItems
                    .CountAsync(o => o.OrderId == id);

                var orderItems = await _webshopContext.OrderItems
                    .FirstOrDefaultAsync(o => o.OrderId == id);

                if (order == null)
                {
                    return NotFound();
                }

                var orderDetailsViewModel = new OrderDetailViewModel
                {
                    Id = order.Id,
                    ShippingDate = order.ShippingDate,
                    CreationDate = order.CreationDate,
                    DeletionDate = order.DeletionDate,
                    UpdateDate = order.UpdateDate,
                    IsOpen = order.IsOpen,
                    ProductsCount = productsCount,
                };

                orderDetailsViewModel.OrderItems = await _webshopContext
                .OrderItems.Where(o => o.OrderId == id)
                .Select(orderItem => new OrderItemDetailViewModel
                {

                    Product = new ProductDetailViewModel()
                    {
                        Id = orderItem.Product.Id,
                        Name = orderItem.Product.Name,
                        Description = orderItem.Product.Description,
                        Price = orderItem.Product.Price,
                        Category = orderItem.Product.Category.Name,
                        FormOfEducation = orderItem.Product.FormOfEducation.Name
                    },

                    Quantity = orderItem.Quantity,

                }).ToListAsync();



                orderDetailsViewModel.TotalPrice = orderDetailsViewModel?.OrderItems
                    ?.Sum(item => (item.Quantity * item.Product.Price)) ?? 0;

                return View(orderDetailsViewModel);
            }
        }
    } 
