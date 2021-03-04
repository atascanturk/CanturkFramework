using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Core.DataAccess;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;

namespace Canturk.Framework.Nothwind.DataAccess.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
