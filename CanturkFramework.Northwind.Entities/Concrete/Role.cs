using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanturkFramework.Core.Entities;

namespace CanturkFramework.Northwind.Entities.Concrete
{
    public class Role :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
