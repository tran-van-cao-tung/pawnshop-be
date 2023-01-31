using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Contracts.Authentication
{
    //internal class AuthenticationResponse
    //{
    //}
    public record AuthenticationResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token);
}
