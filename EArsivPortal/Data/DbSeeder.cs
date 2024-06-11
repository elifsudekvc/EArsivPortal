using EArsivPortal.Constants;
using Microsoft.AspNetCore.Identity;

namespace EArsivPortal.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Roller
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Test.ToString()));

            //Admin Oluşturma

            var user = new ApplicationUser
            {
                UserName = "eskvc8841@gmail.com",
                Email = "eskvc8841@gmail.com",
                Name = "Elif",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin.123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }

            //test oluşturma
            var test = new ApplicationUser
            {
                UserName = "test@example.com",
                Email = "test@example.com",
                Name = "Test",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var testInDb = await userManager.FindByEmailAsync(test.Email);
            if (testInDb == null)
            {
                await userManager.CreateAsync(test, "Test.123");
                await userManager.AddToRoleAsync(test, Roles.Test.ToString());
            }


        }

    }
}
