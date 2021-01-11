using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Interface;
using Ecommerce.Data.IRepositories;
using Ecommerce.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Application.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IMapper _mapper;
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductCategoryService(IMapper mapper, IProductCategoryRepository productCategoryRepository,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }
        public ProductCategoryDtos Add(ProductCategoryDtos productDtos)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductCategoryDtos> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.FindAll(x => x.Name.Contains(keyword) || x.Description.Contains(keyword)).OrderBy(x => x.ParentId).
                    ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).ToList();
            else
                return _productCategoryRepository.FindAll().OrderBy(x=>x.ParentId).ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).ToList();
        }

        public void Update(ProductCategoryDtos productDtos)
        {
            throw new System.NotImplementedException();
        }
    }
}
