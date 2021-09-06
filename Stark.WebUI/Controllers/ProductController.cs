using Microsoft.AspNetCore.Mvc;
using Stark.Business.Abstract;
using Stark.Entities.Concrete;
using Stark.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            ProductViewModel model = new ProductViewModel
            {
                Products = products
                //başka veriler gönderilecek ise bu kullanım ile yapılır
                //örneğin categoriler
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Add() => View();
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
            ProductViewModel model = new ProductViewModel { Product = product };
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
