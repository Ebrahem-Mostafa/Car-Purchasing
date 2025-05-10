using CarSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<IdentityUserRole<string>> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" }
            );

            // Seed users
            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                   
   
                    Id = "1",
                    UserName= "omar@gmail.com",
                    NormalizedUserName= "OMAR@GMAIL.COM",
                    Email = "omar@gmail.com",
                    NormalizedEmail = "OMAR@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName= "Omar",
                    LastName="Abdou",
                    Address="bj jbh nbj ",
                    Age=20,
                    PhoneNumber="01112686866",
                    
                    
                },
                new AppUser
                {

                    Id = "6",
                    UserName = "zoz@gmail.com",
                    NormalizedUserName = "ZOZ@GMAIL.COM",
                    Email = "zoz@gmail.com",
                    NormalizedEmail = "ZOZ@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Abdulaziz",
                    LastName = "Abdou",
                    Address = "bj jbh nbj ",
                    Age = 20,
                    PhoneNumber = "01112686866",
                },
                new AppUser
                {
                    Id = "2",
                    UserName = "anas@gmail.com",
                    NormalizedUserName = "ANAS@GMAIL.COM",
                    Email = "anas@gmail.com",
                    NormalizedEmail = "ANAS@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Anas",
                    LastName = "Mohammed",
                    Address = "bj jbh nbj ",
                    Age = 20,
                    PhoneNumber = "01112686866",
                },
                new AppUser
                {

                    Id = "3",
                    UserName = "ebrahim@gmail.com",
                    NormalizedUserName = "EBRAHIM@GMAIL.COM",
                    Email = "ebrahim@gmail.com",
                    NormalizedEmail = "EBRAHIM@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Ebrahim",
                    LastName = "Mustafa",
                    Address = "bj jbh nbj ",
                    Age = 20,
                    PhoneNumber = "01112686866",
                },
                new AppUser
                {

                    Id = "4",
                    UserName = "ehab@gmail.com",
                    NormalizedUserName = "EHAB@GMAIL.COM",
                    Email = "ehab@gmail.com",
                    NormalizedEmail = "EHAB@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Ehab",
                    LastName = "Ahmed",
                    Address = "bj jbh nbj ",
                    Age = 20,
                    PhoneNumber = "01112686866",
                },
                new AppUser
                {

                    Id = "5",
                    UserName = "arsany@gmail.com",
                    NormalizedUserName = "ARSANY@GMAIL.COM",
                    Email = "arsany@gmail.com",
                    NormalizedEmail = "ARSANY@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Ab@123456789"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Arsany",
                    LastName = "Ashraf",
                    Address = "bj jbh nbj ",
                    Age = 20,
                    PhoneNumber = "01112686866",
                }

            );

            // Assign roles to users
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = "1" },  
                new IdentityUserRole<string> { RoleId = "1", UserId = "2" },  
                new IdentityUserRole<string> { RoleId = "1", UserId = "3" },   
                new IdentityUserRole<string> { RoleId = "1", UserId = "4" }, 
                new IdentityUserRole<string> { RoleId = "1", UserId = "5" }

            );
        }
    }
}
