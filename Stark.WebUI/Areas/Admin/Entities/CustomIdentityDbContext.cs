using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Areas.Admin.Entities
{
    public class CustomIdentityDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomIdentityRole>().HasData(new CustomIdentityRole {
                Id = "fab4fac1-c546-41de-aebc-a14da6895711",
                Name ="Admin",
                NormalizedName="ADMIN",
                ConcurrencyStamp= "fab4fac1-c546-41de-aebc-a14da6895711",                
            });

            CustomIdentityUser user = new CustomIdentityUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Tolga",
                NormalizedUserName="TOLGA",
                Email = "tolgabektas00@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "1234567890",
                Confirmed=true
            };

            PasswordHasher<CustomIdentityUser> passwordHasher = new PasswordHasher<CustomIdentityUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "15301530");
            builder.Entity<CustomIdentityUser>().HasData(user);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
                UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
            });

            
            base.OnModelCreating(builder);
        }
    }
}
