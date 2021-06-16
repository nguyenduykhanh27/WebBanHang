using Ecommerce.Application.Dtos;
using Ecommerce.Application.Interface;
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
        [HttpPost("InsertProductCategory")]
        public IActionResult Add(ProductCategoryDtos productCategoryDtos)
        {
            _productCategoryService.Add(productCategoryDtos);
            return Ok();
        }
        [HttpPost("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _productCategoryService.Delete(id);
            return Ok();
        }
        [HttpGet("GetProductHierachy")]
        public IActionResult GetProductHierachy()
        {
            var model = _productCategoryService.GetProductCategoryHieararchy();
            return new OkObjectResult(model);
        }
        [HttpPost("UpdateProduct")]
        public IActionResult Update(ProductCategoryDtos productCategoryDtos)
        {
             _productCategoryService.Update(productCategoryDtos);
            return Ok();
        }
    }
}
 