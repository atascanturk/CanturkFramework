using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canturk.Framework.Nothwind.DataAccess.Abstract;
using CanturkFramework.Northwind.Business.Abstract;
using CanturkFramework.Northwind.Entities.ComplexTypes;
using CanturkFramework.Northwind.Entities.Concrete;

namespace CanturkFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName && u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
