using System.ComponentModel.DataAnnotations;

namespace SimpleAuthMvc.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
