using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class InvoiceDetail
    {
        [Key]
        [ForeignKey("Id")]
        public int Id_Invoice { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
    }
}
