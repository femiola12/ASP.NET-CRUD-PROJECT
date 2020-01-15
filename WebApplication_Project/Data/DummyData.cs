using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Project.Models;

namespace WebApplication_Project.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                      UserManager<ApplicationUsers> userManager,
                      RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Memeber";
            string desc2 = "This is the user role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("gameAdmin@live.com") == null)
            {
                var user = new ApplicationUsers
                {
                    UserName = "gameAdmin@live.com",
                    Email = "gameAdmin@live.com",
                    FirstName = "Game",
                    LastName = "Admin",
                    Street = "Essex",
                    City = "Dagenham",
                    Province = "RM",
                    PostalCode = "RM20 5FH",
                    Country = "United Kingdon",
                    PhoneNumber = "07486345672"

                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }
            if (await userManager.FindByNameAsync("gameAdmin2@live.com") == null)
            {
                var user = new ApplicationUsers
                {
                    UserName = "gameAdmin2@live.com",
                    Email = "gameAdmin2@live.com",
                    FirstName = "Game2",
                    Street = "Essex",
                    City = "Grays",
                    Province = "RM",
                    PostalCode = "RM20 5TD",
                    Country = "United Kingdon",
                    PhoneNumber = "07486345452"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }

                adminId2 = user.Id;
            }
            if (await userManager.FindByNameAsync("gameUser@live.com") == null)
            {
                var user = new ApplicationUsers
                {
                    UserName = "gameUser@live.com",
                    Email = "gameUser@live.com",
                    FirstName = "Game",
                    Street = "Manchester",
                    City = "United",
                    Province = "RM",
                    PostalCode = "RM22 5TD",
                    Country = "United Kingdon",
                    PhoneNumber = "07483445452"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("dd@dd.dd") == null)
            {
                var user = new ApplicationUsers
                {
                    UserName = "dd@dd.dd",
                    Email = "dd@dd.dd",
                    FirstName = "Donald",
                    LastName = "Duck",
                    Street = "Well St",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "V8U R9Y",
                    Country = "Canada",
                    PhoneNumber = "6041234567"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

        }
    }
}

