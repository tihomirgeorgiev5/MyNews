namespace MyNews.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MyNews.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.NewsCategories.Any())
            {
                return;
            }

            await dbContext.NewsCategories.AddAsync(new NewsCategory { Name = "България" });
            await dbContext.NewsCategories.AddAsync(new NewsCategory { Name = "Свят" });
            await dbContext.NewsCategories.AddAsync(new NewsCategory { Name = "Варна" });

            await dbContext.SaveChangesAsync();
        }
    }
}
