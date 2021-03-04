using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Core.Utilities.Common;
using CanturkFramework.Northwind.Business.Abstract;
using Ninject.Modules;

namespace CanturkFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class ServiceModule :NinjectModule 
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }
    }
}
