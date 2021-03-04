using CanturkFramework.Core.DataAccess;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
