using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CodeFirstApplication.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    /*
     1. Enable-Migrations
     2. Add-Migration 'NameForMigrationFile'
     3. Update-Database

        For every change in any of themodel, repeat steps 2 and 3.
   
     Roll Back Syntax:
     Update-Database -TargetMigration: 'MigrationFileName'
                        (or)
     Update-Database - TargetMigration: -1

     Add-Migration 'RecentlyCreatedFileName' - Force

    */

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false){}

        public DbSet<Movies> Movies {get; set;}
        public DbSet<Customers> Customers {get; set;}
        public DbSet<OrderRows> OrderRows {get; set;}
        public DbSet<Orders> Orders {get; set;}

        public static ApplicationDbContext Create()
        {return new ApplicationDbContext();}
    }
}