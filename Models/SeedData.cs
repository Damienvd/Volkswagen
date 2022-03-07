using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volkswagen.Data;
using System;
using System.Linq;

namespace Volkswagen.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VolkswagenContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VolkswagenContext>>()))
            {
                // Look for any movies.
                if (context.Model.Any())
                {
                    return;   // DB has been seeded
                }

                context.Model.AddRange(
                    new Model
                    {
                        Car_Model = "Polo Vivo",
                        Stock = 6,
                        Features = "Black style package",
                        Price = 232500.00M
                    },

                    new Model
                    {
                        Car_Model = "Polo Sedan",
                        Stock = 8,
                        Features = "",
                        Price = 262700.00M
                    },

                    new Model
                    {
                        Car_Model = "Polo",
                        Stock = 1,
                        Features = "I.Q LIGHT matrix LED headlights, Digital cockpit",
                        Price = 311800.00M
                    },

                    new Model
                    {
                        Car_Model = "Golf",
                        Stock = 2,
                        Features = "Leather trim, Touch controls",
                        Price = 682700.00M
                    },

                    new Model
                    {
                        Car_Model = "T-Cross",
                        Stock = 4,
                        Features = "R-Line Trim",
                        Price = 365100.00M
                    },

                    new Model
                    {
                        Car_Model = "T-Roc",
                        Stock = 2,
                        Features = "R-Line Trim",
                        Price = 628900.00M
                    },

                    new Model
                    {
                        Car_Model = "Tiguan",
                        Stock = 4,
                        Features = "IQ.Drive, Allspace variant",
                        Price = 541800.00M
                    },
                   
                    new Model
                    {
                        Car_Model = "Touareg",
                        Stock = 3,
                        Features = "R-Line trim",
                        Price = 1279700.00M
                    },

                    new Model
                    {
                        Car_Model = "Amarok",
                        Stock = 6,
                        Features = "Electronic trailer stabilisation system",
                        Price = 751400.00M
                    },

                    new Model
                    {
                        Car_Model = "Caddy",
                        Stock = 1,
                        Features = "Kombi and Cargo variant",
                        Price = 484200.00M
                    },

                    new Model
                    {
                        Car_Model = "Transporter 6.1",
                        Stock = 3,
                        Features = "Panel van, Crew bus and Cab range variant",
                        Price = 448000.00M
                    },

                    new Model
                    {
                        Car_Model = "Kombi 6.1",
                        Stock = 4,
                        Features = "WeConnect Go",
                        Price = 771100.00M
                    },

                    new Model
                    {
                        Car_Model = "Caravelle 6.1",
                        Stock = 2,
                        Features = "LED headlights",
                        Price = 1255900.00M
                    },

                    new Model
                    {
                        Car_Model = "California 6.1",
                        Stock = 3,
                        Features = "4MOTION capabilities",
                        Price = 1307400.00M
                    },

                    new Model
                    {
                        Car_Model = "Crafter",
                        Stock = 0,
                        Features = "EPS, ABS, TCS and EBD",
                        Price = 658200.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}