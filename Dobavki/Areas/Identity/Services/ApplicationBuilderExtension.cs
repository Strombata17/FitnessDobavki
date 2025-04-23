﻿
using Dobavki.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;


namespace Dobavki.Services
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDataBase(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var services = scope.ServiceProvider;

            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                var userManager = services.GetRequiredService<UserManager<User>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                //Sazdavane na roles
                await SeedRolesAsync(roleManager);
                //sazdavane na SUPER ADMIN s vsi4kite mu roli
                await SeedSuperAdminAsync(userManager);
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An error occurred seeding the DB.");
            }

            return app;
        }
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                await roleManager.CreateAsync(new IdentityRole("User"));
                await roleManager.CreateAsync(new IdentityRole("Guest"));
            }

            public static async Task SeedSuperAdminAsync(UserManager<User> userManager)
            {
                //Seed Default User
                var defaultUser = new User
                {
                    UserName = "superadmin",
                    Email = "superadmin@gmail.com",
                    FirstName = "Stanislav",
                    LastName = "Bichev",
                    PhoneNumber = "0899899999",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    DateRegistor = new DateTime()

                };

                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    var result = await userManager.CreateAsync(defaultUser, "123!@#Qwe");
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(defaultUser, "Admin");
                                           
                    }
                }
            }
        }
    }
