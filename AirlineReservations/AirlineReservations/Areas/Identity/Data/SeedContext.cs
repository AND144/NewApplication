using Microsoft.AspNetCore.Identity;

namespace AirlineReservations.Areas.Identity.Data
{
    public class SeedContext
    {
        public static async Task seedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Customer.ToString()));

        }

        public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultAdmin = new ApplicationUser
            {
                UserName = "Admin123@gmail.com",
                Email = "Admin123@gmail.com",
                EmailConfirmed = true,
                Name = "Demo",
                City = "London",
                Adress = "London,Uk"
            };
            if (userManager.Users.All(u => u.Id != defaultAdmin.Id))
            {
                var user = await userManager.CreateAsync(defaultAdmin, "Admin123@");

                if (user.Succeeded)
                {
                    await userManager.AddToRoleAsync(defaultAdmin, "Admin");



                }
            }

        }

        public static class Enums
        {
            public enum Roles
            {
                Admin,
                Customer
            }
        }
    }
}
