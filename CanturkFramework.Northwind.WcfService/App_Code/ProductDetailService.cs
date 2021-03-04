using CanturkFramework.Northwind.Business.ServiceContrats.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CanturkFramework.Northwind.Business.Abstract;
using CanturkFramework.Northwind.Business.DependencyResolvers.Ninject;
using CanturkFramework.Northwind.Entities.Concrete;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService : IProductDetailService
{
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}