using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Northwind.Entities.Concrete;

namespace CanturkFramework.Northwind.Business.ServiceContrats.Wcf
{
    [ServiceContract]
    public interface IProductDetailService
    {
        [OperationContract]
        List<Product> GetAll();
    }
}
