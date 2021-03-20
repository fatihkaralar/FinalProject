﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int categoryId);

        List<Product> GetAllByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
    }
}
