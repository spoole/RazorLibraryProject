using Microsoft.AspNetCore.Identity;

namespace RazorLibraryProject.Models
{
    public class User : IdentityUser
    {
        string? role;

        public User() {
            Id = string.Empty;
            UserName = string.Empty;
            Email= string.Empty;
            EmailConfirmed= false;
            PhoneNumber= string.Empty;
            PhoneNumberConfirmed= false;
            NormalizedEmail= string.Empty;
            NormalizedUserName= string.Empty;
            PasswordHash= string.Empty;
            TwoFactorEnabled= false;
            LockoutEnabled= true;
            LockoutEnd = null;
            role = string.Empty;
        }
    }
}
