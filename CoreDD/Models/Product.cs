using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Column(TypeName = "nvarchar(550)")]
        //[Required(ErrorMessage = "This field is required.")]
        [DisplayName("Image Name")]
        public string Image { get; set; }
        [Column(TypeName = "nvarchar(550)")]       
        [DisplayName("Image")]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        [DisplayName("Sale Price")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal? SalePrice { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Time Book")]
        public int? TimesBooked { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
    }
}
