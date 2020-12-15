    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3.DatabaseConnectivity.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Product Name is required")]
        [Display(Name="Product Name")]
        [StringLength(50, ErrorMessage ="Product Name should less than or equal to 50 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product Supplier is required")]
        public string Supplier { get; set; }
    }
}