using Identity.Server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<Gender> Genders => Set<Gender>();
        public DbSet<Photo> Photos => Set<Photo>();
        public DbSet<Interest> Interests => Set<Interest>();
        public DbSet<UserInterest> UserInterests=> Set<UserInterest>();
        public DbSet<Orientation> Orientations => Set<Orientation>();
        public DbSet<UserOrientation> UserOrientations => Set<UserOrientation>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
        }
    }
}