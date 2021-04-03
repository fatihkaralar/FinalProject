using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService iProductService)
        {
            _productService = iProductService;
        }
        [HttpGet]
        public List<Product> Get()
        {
           
            var result=_productService.GetAll();
            return result.Data;
        }
        

    }
}
