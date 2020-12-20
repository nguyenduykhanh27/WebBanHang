using Ecommerce.Data.Enums;
using Ecommerce.Data.Interfaces;
using Ecommerce.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Languages")]
    public class Language : DomainEntity<string>, ISwitchable
    {
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        public string IsDefault { get; set; }
        public string Resource { get; set; }
        public Status Status { get; set; }
    }
}
