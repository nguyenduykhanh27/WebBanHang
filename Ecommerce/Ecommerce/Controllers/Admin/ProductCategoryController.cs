using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers.Admin
{

    public class ProductCategoryController : BaseApiController
    {
        private  IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        [HttpGet("GetAll/{keyword}")]
        public IActionResult GetAll(string keyword)
        {
            var model = _productCategoryService.GetAll(keyword);
            return new OkObjectResult(model);
        }
    }
}
 