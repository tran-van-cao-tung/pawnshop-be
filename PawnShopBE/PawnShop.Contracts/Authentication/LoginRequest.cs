using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Contracts.Authentication
{
    //internal class LoginRequest
    //{
    //}

    public record LoginRequest(
        string Email,
        string Password);
}
