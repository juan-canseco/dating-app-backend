using Identity.Server.Models;

namespace Identity.Server.Data.Seeders
{
    public class InterestSeeder
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            if (context.Interests.Any())
            {
                return;
            }

            var interests = new Interest[]
            {
                new Interest {Name = "Travel"},
                new Interest {Name = "Outdoors"},
                new Interest {Name = "Adventure"},
                new Interest {Name = "Hiking"},
                new Interest {Name = "Fishing"},
                new Interest {Name = "Hunting"},
                new Interest {Name = "Camping"},
                new Interest {Name = "Beach"},
                new Interest {Name = "Smoke"},
                new Interest {Name = "Tatto"},
                new Interest {Name = "420"},
                new Interest {Name = "Music"},
                new Interest {Name = "Books"},
                new Interest {Name = "Movies"},
                new Interest {Name = "Write"},
                new Interest {Name = "Concerts"},
                new Interest {Name = "Video Games"},
                new Interest {Name = "Netflix"},
                new Interest {Name = "Work"},
                new Interest {Name = "Nerd"},
                new Interest {Name = "Student"},
                new Interest {Name = "God"},
                new Interest {Name = "Family"},
                new Interest {Name = "Jokes"},
                new Interest {Name = "Laugh"},
                new Interest {Name = "Animals"},
                new Interest {Name = "Dog"},
                new Interest {Name = "Pet"},
                new Interest {Name = "Cat"},
                new Interest {Name = "Gym"},
                new Interest {Name = "Sports"},
                new Interest {Name = "Dancing"},
                new Interest {Name = "Football"},
                new Interest {Name = "Walks"},
                new Interest {Name = "Fitness"},
                new Interest {Name = "Active"},
                new Interest {Name = "Food"},
                new Interest {Name = "Cook"},
                new Interest {Name = "Eat"},
                new Interest {Name = "Pizza"},
                new Interest {Name = "Beer"},
                new Interest {Name = "Food"},
                new Interest {Name = "Drink"},
                new Interest {Name = "Wine"},
                new Interest {Name = "Coffe"}
            };
            context.Interests.AddRange(interests);
            await context.SaveChangesAsync();
        }
    }
}
