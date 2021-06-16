using Ecommerce.Data.Entities;
using Ecommerce.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
        }

    }
}
