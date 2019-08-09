using System.ComponentModel.DataAnnotations;

namespace FormSub.Models{
    public class User{
        [Required]
        [MinLength(4, ErrorMessage = "Name must be at least 4 characters")]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Age")]
        public int Age {get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string Password {get;set;}
    }
}