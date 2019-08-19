using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "datetime")]
        [DisplayName("Hire date")]
        public DateTime InvoiceDate { get; set; }
        [Column(TypeName = "nvarchar(550)")]
        [DisplayName("Address")]
        public string Address { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [Column(TypeName = "money")]
        [DisplayName("Sale Price")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal? Total { get; set; }
        public ICollection<InvoiceDetail> InvoicesDetails { get; set; }
    }
}
