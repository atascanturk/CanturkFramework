using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Core.DataAccess.EntityFramework;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using(NorthwindContext context = new NorthwindContext()) 
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName };

                return result.ToList();
            }

            
        }
    }
}
