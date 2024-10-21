using Microsoft.AspNetCore.Identity;

namespace SimpleAuthMvc.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
