 
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UltimitAts.Data.Entities; 

namespace UltimitAts.Data.initializer
{
    public class DbInitializer: IDbInitializer
    {

        private readonly DataContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(DataContext db, UserManager<ApplicationUser> userManager , RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public void Initialize(DataContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (!dbContext.Users.Any())
            { 
                    var xx = _roleManager.FindByNameAsync("Admin").Result;
                    if (xx == null)
                    {

                        _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult(); 

                    }
                    //else {
                    //    return;
                    //}

                    ApplicationUser adminUser = new ApplicationUser() {
                        UserName = "test",
                        Email = "admin1@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0599999999" ,
                        FirstName="mahmoud",
                        LastName="ahmda",
                        Password= "Test@123456789"

                    }; 
    
                    var user =  _userManager.CreateAsync(adminUser, adminUser.Password).GetAwaiter().GetResult();
                    adminUser.Id = _db.Users.Where(e => e.Email == adminUser.Email).First().Id;
                    _userManager.AddToRoleAsync(adminUser, "Admin").GetAwaiter().GetResult();
            }

        }
    }


    
}
