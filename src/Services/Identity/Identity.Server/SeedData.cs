using Serilog;
using Identity.Server.Data;
using Identity.Server.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Identity.Server
{
    public class SeedData
    {
        public static async void EnsureSeedData(WebApplication app)
        {
            using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.Migrate();

                Log.Information("Seeding database...");
                await InterestSeeder.Seed(context);
                await GenderSeeder.Seed(context);
                await OrientationSeeder.Seed(context);
                Log.Information("Done seeding database. Exiting.");


            }
        }
    }
}