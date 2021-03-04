using CanturkFramework.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override global::NHibernate.ISessionFactory InitializeFactory()
        {
            return FluentNHibernate.Cfg.Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(c=>c.FromConnectionStringWithKey("NorthwindContext"))
                ).Mappings(t=>t.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
