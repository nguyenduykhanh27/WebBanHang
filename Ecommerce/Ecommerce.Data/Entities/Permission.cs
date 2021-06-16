using Ecommerce.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Permissions")]
    public class Permission : DomainEntity<int>
    {
        public Permission() { }
        public Permission(Guid roleId, string functionId, bool canCreate, bool canRead, bool canUpdate, bool canDelete)
        {
            RoleId = roleId;
            FunctionId = functionId;
            CanCreat = canCreate;
            CanRead = canRead;
            CanUpdate = canUpdate;
            CanDelete = canDelete;
        }
        [Required]
        public Guid RoleId { get; set; }
        [Required]
        [StringLength(128)]
        public string FunctionId { get; set; }
        public bool CanCreat { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        [ForeignKey("GuidId")]
        public virtual AppRole AppRole { get; set; }
        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }
    }
}
