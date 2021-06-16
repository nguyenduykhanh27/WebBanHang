using Ecommerce.Data.Enums;
using Ecommerce.Data.Interfaces;
using Ecommerce.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, IDateTracking, ISwitchable, IHasSeoMetaData
    {
        public Product()
        {
            ProductTags = new List<ProductTag>();
        }
        public Product(string name, int categoryId, string thumbnailImage, decimal price, decimal? promotionPrice,
            decimal originalPrice, string description, string content, bool? homeFlag, bool? hotFlag,
            int? viewCount, string tag, Status status, string seoPageTittle, string seoAlias, string seoKeyword, string seoDescription)
        {
            Name = name;
            CategoryId = categoryId;
            Image = thumbnailImage;
            Price = price;
            PromotionPrice = promotionPrice;
            OriginalPrice = originalPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            ViewCount = viewCount;
            Tags = tag;
            Status = status;
            SeoPageTitle = seoPageTittle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeyword;
            SeoDescription = seoDescription;
            ProductTags = new List<ProductTag>();
        }
        public Product(int id, string name, int categoryId, string thumbnailImage, decimal price, decimal? promotionPrice,
            decimal originalPrice, string description, string content, bool? homeFlag, bool? hotFlag,
            int? viewCount, string tag, Status status, string seoPageTittle, string seoAlias, string seoKeyword, string seoDescription)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Image = thumbnailImage;
            Price = price;
            PromotionPrice = promotionPrice;
            OriginalPrice = originalPrice;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            ViewCount = viewCount;
            Tags = tag;
            Status = status;
            SeoPageTitle = seoPageTittle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeyword;
            SeoDescription = seoDescription;
            ProductTags = new List<ProductTag>();
        }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        [Required]
        public decimal OriginalPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        [StringLength(255)]
        public string Unit { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual ICollection<ProductTag> ProductTags { set; get; }

        public string SeoPageTitle { set; get; }

        [StringLength(255)]
        public string SeoAlias { set; get; }

        [StringLength(255)]
        public string SeoKeywords { set; get; }

        [StringLength(255)]
        public string SeoDescription { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
    }
}
