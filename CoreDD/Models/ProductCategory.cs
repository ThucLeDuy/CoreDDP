using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategory_ID { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [Required]
        public string PD_Name { get; set; }
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Description")]
        public string PD_Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
        
}
