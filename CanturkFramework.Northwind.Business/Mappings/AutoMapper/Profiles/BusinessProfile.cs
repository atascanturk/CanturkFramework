using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CanturkFramework.Northwind.Entities.Concrete;

namespace CanturkFramework.Northwind.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile :Profile
    {
        public BusinessProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}
