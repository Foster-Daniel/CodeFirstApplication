using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApplication.Models
{
    public class Movies
    {
        public int ID {get; set;}
            
        [Required]
        [StringLength(100)]
        public string Title {get; set;}

        [Required]
        [DataType(DataType.Date)]
        public int ReleaseYear {get; set;}

        [Required]
        [StringLength(50)]
        public string Director {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price {get; set;}



    }
}