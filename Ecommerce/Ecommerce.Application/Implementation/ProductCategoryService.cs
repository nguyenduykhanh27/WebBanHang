using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ecommerce.Application.Dtos;
using Ecommerce.Application.Interface;
using Ecommerce.Data.Entities;
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
        public void Add(ProductCategoryDtos productDtos)
        {
            var productCategory = _mapper.Map<ProductCategoryDtos, ProductCategory>(productDtos);
            _productCategoryRepository.Add(productCategory);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _productCategoryRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public List<ProductCategoryDtos> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.FindAll(x => x.Name.Contains(keyword) 
                || x.Description.Contains(keyword)).OrderBy(x => x.ParentId).
                    ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).ToList();
            else
                return _productCategoryRepository.FindAll().OrderBy(x=>x.ParentId).
                    ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).ToList();
        }

        public List<ProductCategoryDtos> GetAll()
        {
            return _productCategoryRepository.FindAll().ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).ToList();
        }

        public  static List<ProductCategoryDtos> GetChildren(List<ProductCategoryDtos> children, int parentId)
        {
            var childrenList = children.Where(c => c.ParentId == parentId)
                .Select(c => new ProductCategoryDtos()
            {
                Id = c.Id,
                Name = c.Name,
                ParentId = c.ParentId,
                Children = GetChildren(children,c.Id)
            }).ToList();
            return childrenList;
        }

        public List<ProductCategoryDtos> GetProductCategoryHieararchy()
        {
            var productCategories = GetAll();
            var productCategoryHierachy = _productCategoryRepository.FindAll().
                ProjectTo<ProductCategoryDtos>(_mapper.ConfigurationProvider).Where(c => c.ParentId == null).Select(c => new ProductCategoryDtos()
            {
                Id = c.Id,
                Name = c.Name,
                ParentId = c.ParentId,
                Children = GetChildren(productCategories,c.Id)
            }).ToList();
            return productCategoryHierachy;
        }

        public void Update(ProductCategoryDtos productDtos)
        {
            var productsUpdate = _mapper.Map<ProductCategoryDtos, ProductCategory>(productDtos);
            _productCategoryRepository.Update(productsUpdate);
            _unitOfWork.Commit();
        }
    }
}
