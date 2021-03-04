using CanturkFramework.Northwind.Business.Abstract;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CanturkFramework.Northwind.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get() 
        {
            return _productService.GetAll();
        }
    }
}
