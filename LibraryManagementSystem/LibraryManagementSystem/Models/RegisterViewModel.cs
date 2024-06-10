using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "用户名是必填项。")]
        [Display(Name = "用户名")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "密码是必填项。")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "确认密码是必填项。")]
        [Display(Name = "确认密码")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; } = null!;

    }
}
