using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDD.Models
{
    public class StoreUser
    {
        [Key]
        public int UserId { get; set; }
        [EmailAddress]
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]        
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Gender")]
        public int? Gender { get; set; }
        [Column(TypeName = "datetime")]
        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Birth Date is required.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public DateTime? Dob { get; set; }
        [Phone]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Phone Number")]
        public string Phonenumber { get; set; }
        [Column(TypeName = "nvarchar(550)")]
        [DisplayName("Address")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(750)")]
        [DisplayName("Image Name")]
        public string Image { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
