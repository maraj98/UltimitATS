using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UltimitAts.Data.Entities;

namespace UltimitAts.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        
        }

         

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}