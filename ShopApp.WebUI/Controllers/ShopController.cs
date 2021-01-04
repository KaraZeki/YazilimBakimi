using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
       // private ICategoryService _categoryService;
        public ShopController(
            IProductService productService)
        {
            _productService = productService;
           // _categoryService = categoryService;
        }
        public IActionResult Details(int? id)
        {
            if(id==null)
                {
                    return NotFound();
                }

            Product product = _productService.GetProductDetails((int)id);
                //Categories = _categoryService.GetAll()
                
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailsModel()
            {
                Product = product,
                Categories = product.ProdctCategories.Select(x => x.Category).ToList(),
                Reviews = product.Reviews
            }) ;
        }

        //products/telefon?page=1 örnektir.
        public IActionResult List()
        {
            return View();
        }
        public async Task<IActionResult> ListPartial(string data)
        {
            Product product = new Product();
            product = JsonConvert.DeserializeObject<Product>(data);

            return PartialView("_product", product);
        }

        public async Task<JsonResult> ListData(string category, int page = 1, string orderBy = null)
        {
            const int pagesize = 3;
            var productLM = new ProducListModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    ItemsPerPage = pagesize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductByCategory(category, page, pagesize).ToList()
            };

            //ürünü sıralama 
            //01 en düşük fiyat 
            //02 en yüksek fiyat 
            //03 en yeniler 
            //04 diğer
            if (orderBy == "01")
            {
                productLM.Products = productLM.Products.OrderBy(x => x.Price).ToList();
            }
            if (orderBy == "02")
            {
                productLM.Products = productLM.Products.OrderByDescending(x => x.Price).ToList();
            }


            return Json(productLM);
        }
    }
}