﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CanturkFramework.Northwind.Entities.Concrete;

namespace CanturkFramework.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}