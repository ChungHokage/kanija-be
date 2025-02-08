using Microsoft.AspNetCore.Identity;

namespace kanija_database.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
        public DateTime? CreatedTime { get; set; }

        public AppUser()
        {
            DisplayName = "Unknown";
        }
    }
}