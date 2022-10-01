using Howest.DeVarens.Core.Entities;
using Howest.DeVarens.Web.Areas.Admin.ViewModels;
using Howest.DeVarens.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Howest.DeVarens.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FormOfEducationController : Controller
    {
        private readonly WebshopContext _webshopContext;

        public FormOfEducationController(WebshopContext webshopContext)
        {
            _webshopContext = webshopContext;
        }

        public async Task<IActionResult> Index()
        {
            FormOfEducationIndexViewModel formOfEducationIndexViewModel = new FormOfEducationIndexViewModel();
            formOfEducationIndexViewModel.FormsOfEducation
            = await _webshopContext
            .FormOfEducation.Where(f => f.DeletionDate == null)
            .OrderBy(f => f.DisplayOrder)
            .Select(f => new FormOfEducationDetailsViewModel
            {
                Id = f.Id,
                Name = f.Name,
                Description = f.Description
            }).ToListAsync();

            return View(formOfEducationIndexViewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var educationForm = await _webshopContext.FormOfEducation.FirstOrDefaultAsync(c => c.Id == id);
            if (educationForm == null)
            {
                return NotFound();
            }

            var productsCount = await _webshopContext.Products
                .CountAsync(p => p.FormOfEducation == educationForm);

            var formOfEductionDetailsViewModel = new FormOfEducationDetailsViewModel
            {
                Id = educationForm.Id,
                Name = educationForm.Name,
                Description = educationForm.Description,
                DisplayOrder = educationForm.DisplayOrder,
                ProductsCount = productsCount
            };

            ////return to view
            return View(formOfEductionDetailsViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            FormOfEducationCreateViewModel formOfEducationCreateViewModel = new();

            return View(formOfEducationCreateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FormOfEducationCreateViewModel viewModel)
        {
            FormOfEducation newForm = new FormOfEducation
            {
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                DisplayOrder = viewModel.DisplayOrder,
                Description = viewModel.Description,
                CreationDate = DateTime.Now
            };

            var maxDisplayOrder = await _webshopContext.FormOfEducation
                .MaxAsync(formOfEducation => formOfEducation.DisplayOrder) + 1;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            else if (viewModel.DisplayOrder < maxDisplayOrder)
            {
                await _webshopContext.FormOfEducation
                    .Where(formOfEducation => formOfEducation.DisplayOrder >= viewModel.DisplayOrder)
                    .ForEachAsync(formOfEducation => formOfEducation.DisplayOrder++);
            }
            else if (viewModel.DisplayOrder > maxDisplayOrder)
            {
                newForm.DisplayOrder = maxDisplayOrder;
            }

            _webshopContext.FormOfEducation.Add(newForm);
            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                TempData["Error"] = "Kan opleidingsvorm niet aanmaken.";
                return RedirectToAction("Create");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var formOfEducation = _webshopContext.FormOfEducation.FirstOrDefault(f => f.Id == id);
            if (formOfEducation == null)
            {
                return NotFound();
            }

            var formOfEducationCreateViewModel = new FormOfEducationCreateViewModel
            {
                Id = formOfEducation.Id,
                Name = formOfEducation.Name,
                Description = formOfEducation.Description,
                DisplayOrder = formOfEducation.DisplayOrder
            };
            return View(formOfEducationCreateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(FormOfEducationCreateViewModel formOfEducationCreateViewModel)
        {
            var newForm = _webshopContext.FormOfEducation
                .FirstOrDefault(f => f.Id == formOfEducationCreateViewModel.Id);
            if (newForm == null)
            {
                return NotFound();
            }

            newForm.Id = formOfEducationCreateViewModel.Id;
            newForm.Name = formOfEducationCreateViewModel.Name;
            newForm.Description = formOfEducationCreateViewModel.Description;
            var oldDisplayOrder = newForm.DisplayOrder;
            newForm.DisplayOrder = formOfEducationCreateViewModel.DisplayOrder;

            var maxDisplayOrder = await _webshopContext.FormOfEducation
                .MaxAsync(formOfEducation => formOfEducation.DisplayOrder) + 1;

            if (!ModelState.IsValid)
            {
                return View(formOfEducationCreateViewModel);
            }
            else if (
                (formOfEducationCreateViewModel.DisplayOrder <= maxDisplayOrder)
                && (oldDisplayOrder != formOfEducationCreateViewModel.DisplayOrder)
            ) {
                await _webshopContext.FormOfEducation
                    .Where(formOfEducation => (formOfEducation.DisplayOrder
                        >= formOfEducationCreateViewModel.DisplayOrder)
                        && (formOfEducation.Id != formOfEducationCreateViewModel.Id))
                    .ForEachAsync(formOfEducation => formOfEducation.DisplayOrder++);
            }
            else if (formOfEducationCreateViewModel.DisplayOrder > maxDisplayOrder)
            {
                newForm.DisplayOrder = maxDisplayOrder;
            }

            try
            {
                await _webshopContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                TempData["Error"] = "Kon de opleidingsvorm niet aanpassen.";
                return RedirectToAction("Edit");
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
                TempData["Error"] = "Er zijn nog producten gekoppeld aan deze opleidingsvorm. Kon de opleidingsvorm niet verwijderen.";
                return RedirectToAction("Details", new { id = id });
            }

            ViewBag.Id = id;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            //delete movie
            var formOfEducation = await _webshopContext
                .FormOfEducation
                .FirstOrDefaultAsync(f => f.Id == id);

            if (formOfEducation == null)
            {
                return NotFound();
            }

            formOfEducation.DeletionDate = DateTime.Now;

            //_movieContext.Movies.Remove(movie);

            await _webshopContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
