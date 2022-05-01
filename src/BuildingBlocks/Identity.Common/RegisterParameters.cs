using System.ComponentModel.DataAnnotations;

namespace Identity.Common;

public class RegisterParameters
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [Compare(nameof(Password), ErrorMessage = "Пароли не совпадают")]
    public string PasswordConfirm { get; set; }
}