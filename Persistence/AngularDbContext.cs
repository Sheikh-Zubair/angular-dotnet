using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions<AngularDbContext> options)
            : base(options)
        {

        }
    }
}