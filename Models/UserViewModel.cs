using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class UserViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be greater than 6 chars!")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
