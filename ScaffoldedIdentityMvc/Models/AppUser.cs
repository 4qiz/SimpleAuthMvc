using Microsoft.AspNetCore.Identity;

namespace ScaffoldedIdentityMvc.Models
{
    public class AppUser : IdentityUser
    {
        public string MyProperty { get; set; } = string.Empty;
    }
}
