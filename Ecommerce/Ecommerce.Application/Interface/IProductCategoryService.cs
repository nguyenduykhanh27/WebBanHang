using Ecommerce.Application.Dtos;
using System.Collections.Generic;

namespace Ecommerce.Application.Interface
{
    public interface IProductCategoryService
    {
        ProductCategoryDtos Add(ProductCategoryDtos productDtos);
        void Delete(int id);
        void Update(ProductCategoryDtos productDtos);
        List<ProductCategoryDtos> GetAll(string keyword);
    }
}
