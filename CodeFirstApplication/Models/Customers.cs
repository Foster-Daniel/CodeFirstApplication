using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApplication.Models
{
    public class Customers
    {
        public int ID {get; set;}

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string BillingAddress { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string BillingZip { get; set; }

        [Required]
        [StringLength(50)]
        public string BillingCity { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryAddress { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string DeliveryZip { get; set; }

        [Required]
        [StringLength(50)]
        public string DeliveryCity { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
    }
}