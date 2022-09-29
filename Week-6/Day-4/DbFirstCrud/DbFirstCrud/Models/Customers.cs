using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstCrud.Models
{
    public partial class Customers
    {
        [Key]
        [StringLength(15)]
        public string CustomerId { get; set; }
        [Required]
        [StringLength(75)]
        public string FirtsName { get; set; }
        [Required]
        [StringLength(75)]
        public string LastName { get; set; }
        [StringLength(500)]
        public string PhotoUrl { get; set; }
    }
}
