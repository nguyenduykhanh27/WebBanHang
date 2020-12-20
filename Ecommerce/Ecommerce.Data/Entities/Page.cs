using Ecommerce.Data.Enums;
using Ecommerce.Data.Interfaces;
using Ecommerce.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Pages")]
    public class Page : DomainEntity<int>, ISwitchable
    {
        public Page() { }
        public Page(int id, string name, string alias, string content, Status status)
        {
            Id = id;
            Name = name;
            Alias = alias;
            Content = content;
            Status = status;
        }

        public Page(string name, string alias, string content, Status status)
        {
            Name = name;
            Alias = alias;
            Content = content;
            Status = status;
        }
        [StringLength(256)]
        [Required]
        public string Name { get; set; }
        [StringLength(256)]
        public string Alias { get; set; }
        public string Content { get; set; }
        public Status Status { get; set; }
    }
}
