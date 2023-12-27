﻿using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Services
{
    public interface IProductService
    {
        List<Product> GetProduct();
        Product Add(Product product);
        void Delete(int id);
        Product GetProductById(int id);
        Product Update(int id, Product product);
    }
}
