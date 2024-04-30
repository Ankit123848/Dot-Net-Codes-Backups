using System.ComponentModel.DataAnnotations;

namespace MVCCORE_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }



        [StringLength(20)]
        [Required(ErrorMessage = "Please enter name of emp")]
        public string Name { get; set; }



        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }



        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }



        [Required(ErrorMessage = "please enter email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]



        public string Email { get; set; }



        public Department department { get; set; }
    }
}
