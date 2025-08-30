using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demoApp0818.Data
{
    // This DbContext manages Identity tables (AspNetUsers, AspNetRoles, etc.)
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            seedRole(builder);


        }
        private  static void seedRole(ModelBuilder builder )
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" }, 
                new IdentityRole() { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }, 
                new IdentityRole() { Name = "HR", ConcurrencyStamp = "3", NormalizedName = "HR" }

                );
        }




    }
}
