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
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            var categories = _categoryService.GetAll();
            ProductViewModel model = new ProductViewModel
            {
                Products = products,
                Categories = categories
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var categories = _categoryService.GetAll();
            ProductViewModel model = new ProductViewModel
            {
                Categories = categories
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(productViewModel.Product);
            }
            else
            {
                _productService.Add(productViewModel.Product);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _productService.GetById(id);
            var categories = _categoryService.GetAll();
            ProductViewModel model = new ProductViewModel
            {
                Product = product,
                Categories = categories
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(productViewModel.Product);
            }
            else
            {
                _productService.Update(productViewModel.Product);
                return RedirectToAction("Index");
            }

        }
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            TempData["message"] = id + " deleted.";
            return RedirectToAction("Index");
        }
    }
}
