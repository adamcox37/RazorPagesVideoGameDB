using RazorPagesVideoGame.Data;
using RazorPagesVideoGame.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesVideoGame.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesVideoGameContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesVideoGameContext>>()))
            {
                // Look for any game
                if (context.VideoGameModel.Any())
                {
                    return; // DB has been seeded
                }

                context.VideoGameModel.AddRange(new VideoGameModel { 
                    GameTitle = "Sonic The Hedgehog 2",
                    ReleaseYear = "1992",
                    Platform = "Sega Genesis",
                    Publisher = "Sega",
                    CompleteCopy = "Yes",
                    PhysicalCopy = "Yes"
                });

                context.SaveChanges();
            }
        }
    }
}
