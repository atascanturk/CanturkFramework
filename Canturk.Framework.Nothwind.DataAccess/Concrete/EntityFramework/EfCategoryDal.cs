using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Core.DataAccess.EntityFramework;
using CanturkFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {
    }
}
