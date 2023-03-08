using Identity.Server.Models;

namespace Identity.Server.Data.Seeders
{
    public class OrientationSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            if (context.Orientations.Any())
            {
                return;
            }


            var orientations = new Orientation[]
            {
                new Orientation { Name = "Straight"},
                new Orientation { Name = "Gay"},
                new Orientation { Name = "Lesbian"},
                new Orientation { Name = "Bisexual"},
                new Orientation { Name = "Asexual"},
                new Orientation { Name = "Demisexual"},
                new Orientation { Name = "Pansexual"},
                new Orientation { Name = "Queer"},
                new Orientation { Name = "Questioning"}
            };


            context.Orientations.AddRange(orientations);

            await context.SaveChangesAsync();
        }
    }
}
