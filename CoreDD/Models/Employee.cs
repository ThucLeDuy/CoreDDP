using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreDD.Models
{
    public class Employee:TagHelper
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
        [Column(TypeName = "datetime")]
        [DisplayName("Hire date")]
        public System.DateTime HireDate { get; set; }
        [Column(TypeName = "money")]
        [DisplayName("Base Salary")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal? BaseSalary { get; set; }
    }
}