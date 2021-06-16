using Ecommerce.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Sizes")]
    public class Size : DomainEntity<int>
    {
        public Size() { }
        public Size(string name)
        {
            Name = name;
        }
        [StringLength(250)]
        public string Name { get; set; }
    }
}
