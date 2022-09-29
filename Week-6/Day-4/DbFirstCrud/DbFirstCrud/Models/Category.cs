using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstCrud.Models
{
    public partial class Category
    {
        [Required]
        [StringLength(2)]
        public string CtCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CatName { get; set; }
    }
}
