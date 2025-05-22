using ToySwap.Api.Models.Entities;

namespace ToySwap.Api.Data
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Toys.Any()) return;

            var toys = new List<Toy>
            {
                new Toy { Name = "Lego Pirates", Condition = "Used", MinAge = 7, Description = "Full set, well loved", ImageUrl = "" },
                new Toy { Name = "Wooden Train", Condition = "New", MinAge = 2, Description = "Unopened box", ImageUrl = "" },
                new Toy { Name = "Dollhouse", Condition = "Like New", MinAge = 4, Description = "All furniture included", ImageUrl = "" }
            };

            context.Toys.AddRange(toys);
            context.SaveChanges();
        }
    }
}