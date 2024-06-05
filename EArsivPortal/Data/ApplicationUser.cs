using Microsoft.AspNetCore.Identity;

namespace EArsivPortal.Data
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
        public string? ProfilePicture { get; set; }

    }
}
