using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="PLease enter valid email!")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength =6, ErrorMessage ="Password must be min 6 chars long!")]
        public string Password { get; set; }

        public string UserType { get; set; }

    }
}
