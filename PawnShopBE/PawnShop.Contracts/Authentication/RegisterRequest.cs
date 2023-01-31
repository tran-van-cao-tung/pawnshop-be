using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Contracts.Authentication
{
    //internal class RegisterRequest
    //{
    //}

    public record RegisterRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password);
}
