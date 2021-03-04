using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Core.DataAccess.NHibernate;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSesion())
            {
              var result =  from p in session.Query<Product>()
                join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                select new ProductDetailDto {
                    CategoryName = c.CategoryName, 
                    ProductId = p.ProductId, 
                    ProductName = p.ProductName 
                };

                return result.ToList();
            }
        }
    }
}
