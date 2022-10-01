using Howest.DeVarens.Web.Areas.Admin.ViewModels;
using Howest.DeVarens.Web.Data;
using Howest.DeVarens.Web.Areas.Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Howest.DeVarens.Web.Areas.Admin.Services;

namespace Howest.DeVarens.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class ShopController : Controller
    {
        private readonly WebshopContext _webshopContext;
        private readonly IFormHelpersService _formHelpersService;

        public ShopController(WebshopContext webshopContext, IFormHelpersService formHelpersService)
        {
            _webshopContext = webshopContext;
            _formHelpersService = formHelpersService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var mediaDetailViewModel = new MediaDetailViewModel();
            var productsIndexViewModel = new ProductsIndexViewModel();

            productsIndexViewModel.Products = await _webshopContext.Products
                .Where(p => p.DeletionDate == null)
                .Select(p => new ProductDetailViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    FormOfEducation = p.FormOfEducation.Name,
                    Category = p.Category.Name,
                    Media = p.Media.Select(p => new MediaDetailViewModel
                    {
                        Title = p.Title,
                        Path = p.Path
                    }).ToList()
                }).Where(p => p.Media.Count != 0).ToListAsync();

            ViewBag.Categories =
                await _formHelpersService.BuildCategoryList();
            ViewBag.FormOfEducations =
                await _formHelpersService.BuildFormOfEducationList();

            return View(productsIndexViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel viewModel)
        {
            ProductsIndexViewModel productsIndexViewModel = new ProductsIndexViewModel();
            productsIndexViewModel.Products
            = await _webshopContext
            .Products
            .Where(p => p.Name.Contains(viewModel.SearchTerm ?? "") || p.Description.Contains(viewModel.SearchTerm ?? ""))
            .Select(p => new ProductDetailViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.Category.Id,
                Category = p.Category.Name,
                FormOfEducationId = p.FormOfEducation.Id,
                FormOfEducation = p.FormOfEducation.Name,
                Media = p.Media.Select(p => new MediaDetailViewModel
                {
                    Title = p.Title,
                    Path = p.Path,
                    DeletionDate = p.DeletionDate
                }).Where(m => m.DeletionDate == null).ToList()
            }).Where(p => p.Media.Count != 0).ToListAsync();

            if (viewModel.CategoryIds != null && viewModel.FormOfEducationIds == null)
            {
                productsIndexViewModel.Products = productsIndexViewModel.Products.Where(p => viewModel.CategoryIds.Contains(p.CategoryId.ToString()));
            }
            else if (viewModel.FormOfEducationIds != null && viewModel.CategoryIds == null)
            {
                productsIndexViewModel.Products = productsIndexViewModel.Products.Where(p => viewModel.FormOfEducationIds.Contains(p.FormOfEducationId.ToString()));

            }
            else if (viewModel.FormOfEducationIds != null && viewModel.CategoryIds != null)
            {
                productsIndexViewModel.Products = productsIndexViewModel.Products.Where(p => viewModel.CategoryIds.Contains(p.CategoryId.ToString()) && viewModel.FormOfEducationIds.Contains(p.FormOfEducationId.ToString()));
            }

            ViewBag.Categories =
                await _formHelpersService.BuildCategoryList();
            ViewBag.FormOfEducations =
                await _formHelpersService.BuildFormOfEducationList();

            if (productsIndexViewModel.Products.Count() == 0)
            {
                TempData["Error"] = "Geen producten gevonden met de opgegeven criteria.";
            }

            return View("Index", productsIndexViewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var product = await _webshopContext.Products
                .Include(c => c.Category)
                .Include(f => f.FormOfEducation)
                .FirstOrDefaultAsync(p => p.Id == id);
            MediaDetailViewModel mediaDetailViewModel = new MediaDetailViewModel();

            var images = _webshopContext.Medias.Select(m => new MediaDetailViewModel
            {
                Title = m.Title,
                Path = m.Path,
                ProductId = m.ProductId.ToString()
            }).Where(m => m.ProductId == id.ToString()).ToList();

            if (product == null)
            {
                return NotFound();
            }

            var productDetailViewModel = new ProductDetailViewModel
            {
                Id = product.Id,
                Name = product.Name ?? "<Geen product naam gevonden>",
                Price = product.Price,
                Description = product.Description ?? "<Geen omschrijving gevonden>",
                Category = product.Category.Name ?? "<Geen categorie gevonden>",
                FormOfEducation = product.FormOfEducation.Name ?? "<Geen opleidingsvorm gevonden>",
                Media = images
            };

            return View(productDetailViewModel);
        }
    }
}
