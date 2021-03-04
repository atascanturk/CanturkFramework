using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CanturkFramework.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<T, T>());
            List<T> result = new Mapper(mapper).Map<List<T>, List<T>>(list);
            return result;
        }

        public static T MapToSameTypeType<T>(T obj)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<T, T>());
            T result = new Mapper(mapper).Map<T, T>(obj);
            return result;
        }
    }
}
