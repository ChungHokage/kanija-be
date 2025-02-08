using System.Reflection;
using kanija_database.Enum;

namespace kanija_database.Entities
{
    public class UserInfor
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public AppUser? AppUser { get; set; }
    }
}