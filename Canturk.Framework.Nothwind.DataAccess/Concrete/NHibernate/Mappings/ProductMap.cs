using CanturkFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();
            Id(x => x.ProductId).Column("ProductID");

            Map(X => X.CategoryId).Column("CategoryID");
            Map(X => X.ProductName).Column("ProductName");
            Map(X => X.QuantityPerUnit).Column("QuantityPerUnit");
            Map(X => X.UnitPrice).Column("UnitPrice");
        }
    }
}
