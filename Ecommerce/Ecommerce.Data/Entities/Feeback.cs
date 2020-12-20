using Ecommerce.Data.Enums;
using Ecommerce.Data.Interfaces;
using Ecommerce.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, IDateTracking
    {
        public Feedback() { }
        public Feedback(int id, string name, string email, string message, Status status)
        {
            Id = id;
            Name = name;
            Email = email;
            Message = message;
            Status = status;
        }
        [StringLength(256)]
        [Required]
        public string Name { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
