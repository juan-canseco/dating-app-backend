using Identity.Server.Models;

namespace Identity.Server.Data.Seeders
{
    public static class GenderSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            if (context.Genders.Any())
            {
                return;
            }
            var genders = new Gender[]
            {
                new Gender { Name = "Woman"},
                new Gender { Name = "Man"},
                new Gender { Name = "Trans Man"},
                new Gender { Name = "Trans Woman"},
                new Gender { Name = "Androgynous"},
                new Gender { Name = "Gender-Fluid"},
                new Gender { Name = "Agender"},
                new Gender { Name = "Bi-Gender"},
                new Gender { Name = "Non-Binary"},
                new Gender { Name = "Non-Conforming"}
            };
            context.Genders.AddRange(genders);
            await context.SaveChangesAsync();
        }
    }
}
