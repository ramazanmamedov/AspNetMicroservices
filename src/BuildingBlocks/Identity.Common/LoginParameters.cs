using System.ComponentModel.DataAnnotations;

namespace Identity.Common;

public class LoginParameters
{
    [Required]
    [EmailAddress]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}