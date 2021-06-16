using Ecommerce.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>
    {
        public Slide() { }
        public Slide(string name, string description, string image, string url, int? displayOrder, bool status, string content, string groupAlias)
        {
            Name = name;
            Description = description;
            Image = image;
            Url = url;
            DisplayOrder = displayOrder;
            Status = status;
            Content = content;
            GroupAlias = groupAlias;
        }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        [Required]
        public string Image { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public string Content { get; set; }
        [StringLength(25)]
        public string GroupAlias { get; set; }
        public bool Status { get; set; }
    }
}
