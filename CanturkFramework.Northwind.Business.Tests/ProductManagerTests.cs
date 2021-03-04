using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Northwind.Business.Concrete.Managers;
using CanturkFramework.Northwind.Entities.Concrete;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CanturkFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
           // ProductManager productManager = new ProductManager(mock.Object);
          //  productManager.Add(new Product());
        }
    }
}
