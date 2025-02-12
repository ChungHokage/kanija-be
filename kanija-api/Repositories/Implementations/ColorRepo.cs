using kanija_api.Repositories.Interfaces;
using kanija_database.EF;
using kanija_database.Entities;

namespace kanija_api.Repositories.Implementations
{
    public class ColorRepo : BaseRepo<Color>, IColorRepo
    {
        public ColorRepo(KanijaDbContext context) : base(context)
        {
        }
    }
}