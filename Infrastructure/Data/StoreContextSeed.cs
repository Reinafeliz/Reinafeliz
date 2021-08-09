using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Core.Entities.MasterAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory, UserManager<AppUser> userManager)
        {
            try
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (!userManager.Users.Any())
                {
                    var user = new AppUser
                    {
                        DisplayName = "Bob",
                        Email = "bob@test.com",
                        UserName = "bob@test.com",
                        Address = new Address
                        {
                            FirstName = "Bob",
                            LastName = "Bobbity",
                            Street = "10 The Street",
                            City = "New York",
                            State = "NY",
                            ZipCode = "90210"
                        }
                    };
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
                if (!context.Countries.Any())
                {
                    // var countryData = File.ReadAllText(path + @"/Data/SeedData/Countries.json");
                    var countryData = File.ReadAllText("../Infrastructure/Data/SeedData/Countries.json");
                    var countries = JsonSerializer.Deserialize<List<Countries>>(countryData);

                    foreach (var country in countries)
                    {
                        context.Countries.Add(country);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.StateCities.Any())
                {
                    var statecityData = File.ReadAllText("../Infrastructure/Data/SeedData/StateCity.json");
                    var stateCities = JsonSerializer.Deserialize<List<StateCity>>(statecityData);

                    foreach (var statecity in stateCities)
                    {
                        context.StateCities.Add(statecity);
                    }

                    await context.SaveChangesAsync();
                }


            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}