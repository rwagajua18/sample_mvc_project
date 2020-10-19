using  Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sampleMvc.Data;
using System;
using System.Linq;

namespace sampleMvc.Models
{
    public static class SeedData
    {
        public static  void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SongContext(
                serviceProvider.GetService<DbContextOptions<SongContext>>()))

            {
                if(context.Songs.Any() && context.Customers.Any())
                {
                    return;
                }

                context.Songs.AddRange(
                    new Song
                    {
                        Title = "Love is blind" ,
                        Duration = 3.05,
                        Genre = "Soul",
                        ArtistName = "Ellen Mcgee",
                        Album = "love in the air"
                    },

                    new Song
                    {
                        Title = "Togther as one" ,
                        Duration = 4.00,
                        Genre = "R&B",
                        ArtistName = "Tupac Michael",
                        Album = "We"
                    },

                    new Song
                    {
                        Title = "Crime" ,
                        Duration = 5.09,
                        Genre = "Pop",
                        ArtistName = "Travis Scott",
                        Album = "Astroworld"
                    }  

                );

                context.Customers.AddRange(
                    new Customer
                    {
                        firstName = "Diane",
                        lastName = "Alicia",
                        username = "dalicia",
                        email = "aliciad@wlu.edu"
                    },
                    new Customer
                    {
                        firstName = "Fred",
                        lastName = "Gisa",
                        username = "fgisa",
                        email = "gisa@wlu.edu"
                    }
                );

                context.SaveChanges();
            }
            
        }
        
    }
}