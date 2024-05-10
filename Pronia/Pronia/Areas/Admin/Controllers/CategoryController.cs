using Microsoft.AspNetCore.Mvc;
using Pronia.Business.Services.Abstracts;
using Pronia.Core.Models;
using System.Runtime.CompilerServices;

namespace Pronia.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            _categoryService.AddCategory(category);
            return RedirectToAction("Index");
        }
    }
}
