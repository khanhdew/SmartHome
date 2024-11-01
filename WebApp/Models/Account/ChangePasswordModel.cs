using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class ChangePasswordModel
{
    [Required]
    [Display(Name = "Current password")]
    [DataType(DataType.Password)]
    public string OldPassword { get; set; }
    
    [Required]
    [Display(Name = "New password")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }
    
    [Required]
    [Display(Name = "Comfirm new password")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}