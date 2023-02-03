using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(int branchId, string userName, string password, string fullName, string email, DateTime dob, string address, int phone);
        AuthenticationResult Login(string userName, string password);

    }
}
