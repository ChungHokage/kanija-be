using Microsoft.AspNetCore.Identity;

namespace kanija_database.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string? Discription { get; set; }
    }
}