using Howest.DeVarens.Web.Areas.Admin.ViewModels;
using Howest.DeVarens.Web.Areas.Admin.Services;
using Howest.DeVarens.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Howest.DeVarens.Core.Entities;

namespace Howest.DeVarens.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly WebshopContext _webshopContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFileService _fileService;
        private readonly IFormHelpersService _formHelpersService;

        public ProductController(WebshopContext webshopContext,
            IWebHostEnvironment webHostEnvironment,
            IFileService fileService,
            IFormHelpersService formHelpersService)
        {
            _webshopContext = webshopContext;
            _webHostEnvironment = webHostEnvironment;
            _fileService = fileService;
            _formHelpersService = formHelpersService;
        }

        public async Task<IActionResult> Index()
        {
            ProductsIndexViewModel productsIndexViewModel = new();
            MediaDetailViewModel mediaDetailViewModel = new();
            productsIndexViewModel.Products
            = await _webshopContext
            .Products.Where(p => p.DeletionDate == null)
            .Select(p => new ProductDetailViewModel
            {
                Id = p.Id,
                Name = p.Name,
                DeletionDate = p.DeletionDate,
                Media = p.Media.Select(p => new MediaDetailViewModel
                {
                    Title = p.Title,
                    Path = p.Path,
                    DeletionDate = p.DeletionDate
                }).Where(m => m.DeletionDate == null).ToList()
            }).Where(p => p.Media.Count != 0).ToListAsync();

            return View(productsIndexViewModel);
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
                Category = product.Category?.Name ?? "<Geen categorie gevonden>",
                FormOfEducation = product.FormOfEducation?.Name ?? "<Geen opleidingsvorm gevonden>",
                Media = images
            };

            return View(productDetailViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create(Guid id)
        {
            var product = await _webshopContext
                .Products
                .FirstOrDefaultAsync(p => p.Id == id);
            if (product != null && product.DeletionDate != null)
            {
                product.DeletionDate = null;
                await _webshopContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                ProductCreateEditViewModel productCreateEditViewModel = new();

                productCreateEditViewModel.FormOfEducations =
                    await _formHelpersService.BuildFormOfEducationList();

                productCreateEditViewModel.Categories =
                    await _formHelpersService.BuildCategoryList();

                return View(productCreateEditViewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.FormOfEducations =
                   await _formHelpersService.BuildFormOfEducationList();
                viewModel.Categories =
                    await _formHelpersService.BuildCategoryList();

                return View(viewModel);
            }

            Product newProduct = new()
            {
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                Price = viewModel.Price,
                Description = viewModel.Description,
                FormOfEducationId = viewModel.FormOfEducationId,
                CategoryId = viewModel.CategoryId,
                CreationDate = DateTime.Now
            };

            if (newProduct.Price < 0.01m)
            {
                ProductCreateEditViewModel productCreateEditViewModel = new();
                productCreateEditViewModel.FormOfEducations =
                    await _formHelpersService.BuildFormOfEducationList();
                productCreateEditViewModel.Categories =
                    await _formHelpersService.BuildCategoryList();

                ModelState.AddModelError("Price", "De prijs moet een positief getal zijn en niet nul.");
                return View("Create", productCreateEditViewModel);
            }

            var fileExtensions = new List<string>
            {
                ".jpeg",
                ".jpg",
                ".png"
            };

            if (viewModel.Images != null)
            {
                foreach (var file in viewModel.Images)
                {
                    if (fileExtensions.Contains(Path.GetExtension(file.FileName)))
                    {
                        var newImage = new Media
                        {
                            Id = Guid.NewGuid(),
                            ProductId = newProduct.Id,
                            CreationDate = DateTime.Now,
                            Title = newProduct.Name,
                            Path = await _fileService.AddOrUpdateFile(file,
                            "", _webHostEnvironment)
                        };
                        _webshopContext.Medias.Add(newImage);
                    }
                    else
                    {
                        TempData["Error"] = "Gelieve een geldlige afbeelding te selecteren.";
                        return RedirectToAction("Create");
                    }
                }
            }

            _webshopContext.Products.Add(newProduct);
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

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await _webshopContext
                .Products
                .FirstOrDefaultAsync(p => p.Id == id);

            try
            {
                ProductCreateEditViewModel productCreateEditViewModel = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    FormOfEducationId = product.FormOfEducationId,
                    FormOfEducations = await _formHelpersService.BuildFormOfEducationList(),
                    Categories = await _formHelpersService.BuildCategoryList()
                };
                return View(productCreateEditViewModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductCreateEditViewModel productCreateEditViewModel)
        {
            if (productCreateEditViewModel.Images != null)
            {
                if (!ModelState.IsValid)
                {
                    productCreateEditViewModel.Categories = await _formHelpersService
                        .BuildCategoryList();
                    productCreateEditViewModel.FormOfEducations = await _formHelpersService
                        .BuildFormOfEducationList();

                    return View(productCreateEditViewModel);
                }
            }

            var product = await _webshopContext
                .Products
                .FirstOrDefaultAsync(p => p.Id == productCreateEditViewModel.Id);

            product.Name = productCreateEditViewModel.Name;
            product.Price = productCreateEditViewModel.Price;
            product.Description = productCreateEditViewModel.Description;
            product.CategoryId = productCreateEditViewModel.CategoryId;
            product.FormOfEducationId = productCreateEditViewModel.FormOfEducationId;
            product.UpdateDate = DateTime.Now;

            if (product.Price < 0.01m)
            {
                productCreateEditViewModel.FormOfEducations =
                    await _formHelpersService.BuildFormOfEducationList();
                productCreateEditViewModel.Categories =
                    await _formHelpersService.BuildCategoryList();

                ModelState.AddModelError("Price", "De prijs moet een positief getal zijn en niet nul.");
                return View("Edit", productCreateEditViewModel);
            }

            var fileExtensions = new List<string>
            {
                ".jpeg",
                ".jpg",
                ".png"
            };

            var productImages = _webshopContext
                .Medias
                .Where(m => m.ProductId == productCreateEditViewModel.Id && m.DeletionDate == null);

            if (productCreateEditViewModel.Images != null)
            {
                foreach (var file in productCreateEditViewModel.Images)
                {
                    if (fileExtensions.Contains(Path.GetExtension(file.FileName)))
                    {
                        foreach (var image in productImages)
                        {
                            image.DeletionDate = DateTime.Now;
                        }
                        var newImage = new Media
                        {
                            Id = Guid.NewGuid(),
                            ProductId = product.Id,
                            CreationDate = DateTime.Now,
                            Title = product.Name,
                            Path = await _fileService.AddOrUpdateFile(file,
                            "", _webHostEnvironment)
                        };
                        _webshopContext.Medias.Add(newImage);
                    }
                    else
                    {
                        TempData["Error"] = "Gelieve een geldige afbeelding te selecteren.";
                        return RedirectToAction("Create");
                    }
                }
            }

            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                TempData["Error"] = "Kan product niet aanpassen.";
                return RedirectToAction("Edit");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ConfirmDelete(Guid id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _webshopContext.Products
                .FirstOrDefaultAsync(p => p.Id == id);
            try
            {
                product.DeletionDate = DateTime.Now;
                await _webshopContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> ShowDeleted()
        {
            ProductsIndexViewModel productsIndexViewModel = new();
            productsIndexViewModel.Products
            = await _webshopContext
            .Products.Where(p => p.DeletionDate != null)
            .Select(p => new ProductDetailViewModel
            {
                Id = p.Id,
                Name = p.Name,
                DeletionDate = p.DeletionDate,
                Media = p.Media.Select(p => new MediaDetailViewModel
                {
                    Title = p.Title,
                    Path = p.Path
                }).ToList()
            }).Where(p => p.Media.Count != 0).ToListAsync();

            return View(productsIndexViewModel);
        }
    }
}