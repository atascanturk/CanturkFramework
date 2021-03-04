using Canturk.Framework.Nothwind.DataAccess.Abstract;
using Canturk.Framework.Nothwind.DataAccess.Concrete.EntityFramework;
using Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate.Helpers;
using CanturkFramework.Core.DataAccess;
using CanturkFramework.Core.DataAccess.EntityFramework;
using CanturkFramework.Core.DataAccess.NHibernate;
using CanturkFramework.Northwind.Business.Abstract;
using CanturkFramework.Northwind.Business.Concrete.Managers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanturkFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule :NinjectModule, INinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
