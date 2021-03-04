using CanturkFramework.Northwind.Entities.Concrete;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap :ClassMap<Category>
    {

        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");
            Map(X => X.CategoryName).Column("CategoryName");
            
        }
    }
}
