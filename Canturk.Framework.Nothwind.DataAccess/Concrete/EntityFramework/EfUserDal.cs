using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Core.DataAccess.EntityFramework;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;
using NHibernate.Hql.Ast.ANTLR.Tree;

namespace Canturk.Framework.Nothwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal :EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles
                        on ur.RoleId equals r.Id
                    where ur.UserId == user.Id
                    select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
