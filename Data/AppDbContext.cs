using MediaTrackerAuthenticationService.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaTrackerAuthenticationService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<PlatformConnection> PlatformConnections => Set<PlatformConnection>();
    }
}
