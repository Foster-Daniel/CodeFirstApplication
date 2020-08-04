using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApplication.Models
{
    public class OrderRows
    {
        public int ID { get; set; }

        //[ForeignKey("OrderID")]
        public int OrderID { get; set; }
        public Orders Order { get; set; }

        //[ForeignKey("MovieID")]
        public int MovieID { get; set; }
        public Movies Movie { get; set; }


        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
