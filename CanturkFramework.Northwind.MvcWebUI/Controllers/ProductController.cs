using CanturkFramework.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanturkFramework.Northwind.Entities.Concrete;
using CanturkFramework.Northwind.MvcWebUI.Models;

namespace CanturkFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(
                new Product {CategoryId = 1, ProductName = "Gsm", QuantityPerUnit = "1", UnitPrice = 21});
            return "Added";
        }

        public string AddUpdate()
        {
            _productService.TransactionalOperation(
                new Product { CategoryId = 1, ProductName = "Computer1", QuantityPerUnit = "1", UnitPrice = 19 },
                
                    new Product {CategoryId = 1,ProductId = 2,ProductName = "Computer 2",QuantityPerUnit = "2",UnitPrice = 21});

            return "Done";

        }

        
    }

    
}