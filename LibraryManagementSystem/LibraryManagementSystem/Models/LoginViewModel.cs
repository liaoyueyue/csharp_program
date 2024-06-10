using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "用户名是必填项。")]
        [Display(Name = "用户名")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "密码是必填项。")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

    }


}
