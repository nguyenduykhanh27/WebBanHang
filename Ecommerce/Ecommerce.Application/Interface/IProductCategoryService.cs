using Ecommerce.Application.Dtos;
using System.Collections.Generic;

namespace Ecommerce.Application.Interface
{
    public interface IProductCategoryService
    {
        void Add(ProductCategoryDtos productDtos);
        void Delete(int id);
        void Update(ProductCategoryDtos productDtos);
        List<ProductCategoryDtos> GetAll(string keyword);
        List<ProductCategoryDtos> GetProductCategoryHieararchy();
        List<ProductCategoryDtos> GetAll();

    }
}
