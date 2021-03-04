using Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate;
using Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CanturkFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);


        }

        [TestMethod]
        public void Get_all_with_paremeter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);


        }
    }
}
