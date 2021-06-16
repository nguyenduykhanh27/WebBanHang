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
    [Table("ContactDetails")]
    public class Contact : DomainEntity<string>, ISwitchable
    {
        public Contact() { }
        public Contact(string id, string name, string phone, string email, string website, string address, string other, double? lat, double? lng, Status status)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Website = website;
            Address = address;
            Other = other;
            Lat = lat;
            Lng = lng;
            Status = status;
        }
        [StringLength(250)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Website { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public string Other { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public Status Status { get; set; }
   }
}
