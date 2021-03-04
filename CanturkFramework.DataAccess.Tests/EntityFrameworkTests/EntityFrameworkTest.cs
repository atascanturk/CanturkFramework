using Canturk.Framework.Nothwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CanturkFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);


        }

        [TestMethod]
        public void Get_all_with_paremeter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(p=> p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);


        }
    }
}
