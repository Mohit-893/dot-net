using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstCrud.Models
{
    public partial class Products
    {
        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(2)]
        public string Category { get; set; }
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [StringLength(500)]
        public string ImageUrl { get; set; }
    }
}
