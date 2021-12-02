using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UltimitAts.Data.Entities;

namespace UltimitAts.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
         
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=db;Database=UltimitAts_Users;User=sa;Password=1Secure*Password1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}