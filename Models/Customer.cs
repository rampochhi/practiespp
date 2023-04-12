using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace practiespp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter the Name")]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string? Name { get; set; }
        [Required (ErrorMessage ="Please Enter the Address")]
        public string Address { get; set; }
        [Required (ErrorMessage ="Please Enter the Number")]
        [RegularExpression(@"^[0-9]{10}$")]
        public string Number { get; set; }
        [Required(ErrorMessage ="Enter valid email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
    }
}
//@"^[@\s]+@[^@\s]+\.[^@\s]+$x")
//"^[a-zA-Z ]*$"