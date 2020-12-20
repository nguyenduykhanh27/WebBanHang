using Ecommerce.Data.Enums;
using Ecommerce.Data.Interfaces;
using Ecommerce.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ecommerce.Data.Entities
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISortable
    {
        public Function() { }
        public Function(string name, string url, string parenId, string iconCss, int sortOrder, Status status)
        {
            Name = name;
            URL = url;
            ParentId = parenId;
            IconCss = iconCss;
            SortOrder = sortOrder;
            Status = status;
        }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string URL { get; set; }
        [StringLength(128)]
        public string ParentId { get; set; }
        public string IconCss { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}
