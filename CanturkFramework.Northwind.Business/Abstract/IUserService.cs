using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;

namespace CanturkFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName,string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
