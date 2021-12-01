using System.Text.Json.Serialization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity; 

namespace UltimitAts.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
     
        public string FirstName { get; set; }
        public string LastName { get; set; } 

        [JsonIgnore]
        public string Password { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }



    }
}