using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApplication.Models
{
    public class Orders
    {
        public int ID{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        //[ForeignKey("CustomerID")]
        public int CustomerID {get; set;}
        public Customers Customer {get; set;}
    }
}