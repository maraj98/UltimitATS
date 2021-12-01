using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimitAts.Data.Entities;
using UltimitAts.Data.Models; 
namespace UltimitAts.Infrastructure.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);

       // object Authenticate(AuthenticateRequest model, string v);
    }


}
