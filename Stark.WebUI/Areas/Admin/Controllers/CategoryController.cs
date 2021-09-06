using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stark.Business.Abstract;
using Stark.WebUI.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAll();
            CategoryViewModel model = new CategoryViewModel { Categories = categories };
            return View(model);
        }
        [HttpGet]
        public IActionResult Add() => View();
        [HttpPost]
        public IActionResult Add(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(categoryViewModel.Category);
            }
            else
            {
                _categoryService.Add(categoryViewModel.Category);
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete(int id)
        {
            var product = _productService.GetByCategory(id);
            if (product.Count!=0)
            {
                TempData["message"] = id + " category can not be deleted bcs it has product.";
                return RedirectToAction("Index");
            }
            _categoryService.Delete(id);
            TempData["message"] = id + " deleted.";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryService.GetById(id);
            CategoryViewModel model = new CategoryViewModel
            {
                Category = category
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(categoryViewModel.Category);
            }
            else
            {
                _categoryService.Update(categoryViewModel.Category);
                return RedirectToAction("Index");
            }

        }
    }
}
