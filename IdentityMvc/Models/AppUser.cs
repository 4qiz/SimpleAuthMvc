using Microsoft.AspNetCore.Identity;

namespace IdentityMvc.Models
{
    public class AppUser : IdentityUser
    {
        public string MyProperty { get; set; }
    }
}
