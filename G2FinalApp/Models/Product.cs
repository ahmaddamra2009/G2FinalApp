using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G2FinalApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        [MinLength(30,ErrorMessage ="Min 30 Char")]
        public string ProductDesc { get; set; }
        [Required]
        public decimal Price{ get; set; }
        public int Qty { get; set; }
        public string ProductImage { get; set; }
        public string Category { get; set; }
        public bool inStock { get; set; }
    }
}
