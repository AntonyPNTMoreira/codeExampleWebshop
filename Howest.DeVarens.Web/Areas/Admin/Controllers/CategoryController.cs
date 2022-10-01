
﻿using Microsoft.AspNetCore.Mvc;
using Howest.DeVarens.Web.Areas.Admin.ViewModels;
using Howest.DeVarens.Web.Data;
using Microsoft.EntityFrameworkCore;
using Howest.DeVarens.Core.Entities;

namespace Howest.DeVarens.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly WebshopContext _webshopContext;

        public CategoryController(WebshopContext webshopContext)
        {
            _webshopContext = webshopContext;
        }

        public async Task<IActionResult> Index()
        {
            CategoriesIndexViewModel categoriesIndexViewModel = new CategoriesIndexViewModel();
            categoriesIndexViewModel.Categories
            = await _webshopContext
            .Categories
            .Where(f => f.DeletionDate == null)
            .Select(c => new CategoryDetailViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            }).ToListAsync();

            return View(categoriesIndexViewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var category = await _webshopContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            var productsCount = await _webshopContext.Products
                .CountAsync(p => p.Category == category);

            var categoryDetailViewModel = new CategoryDetailViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ProductsCount = productsCount
            };

            return View(categoryDetailViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categoryCreateIndexViewModel = new CategoryCreateEditViewModel();
            return View(categoryCreateIndexViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            var category = new Category
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                CreationDate = DateTime.Now
            };

            _webshopContext.Categories.Add(category);
            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                TempData["Error"] = "Kon de categorie niet aanmaken.";
                return RedirectToAction("Create");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ConfirmDelete(Guid id)
        {
            var productCount = _webshopContext.Products
                .Count(p => p.Category.Id == id);

            if (productCount > 0)
            {
                TempData["Error"] = "Er zijn nog producten gekoppeld aan deze categorie. Kon de categorie niet verwijderen.";
                return RedirectToAction("Details", new { id = id });
            }

            ViewBag.Id = id;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var category = await _webshopContext
                .Categories
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category.DeletionDate = DateTime.Now;

            await _webshopContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var category = _webshopContext.Categories.FirstOrDefault(c => c.Id == id);
            var categoryCreateIndexViewModel = new CategoryCreateEditViewModel
            {
                Name = category.Name,
                Description = category.Description
            };
            return View(categoryCreateIndexViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoryCreateEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            var category = _webshopContext.Categories.FirstOrDefault(c => c.Id == viewModel.Id);
            category.Name = viewModel.Name;
            category.Description = viewModel.Description;

            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                TempData["Error"] = "Kon de categorie niet aanpassen.";
                return RedirectToAction("Edit");
            }

            return RedirectToAction("Index");
        }
    }
}
