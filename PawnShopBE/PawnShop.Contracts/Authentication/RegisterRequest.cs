using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Contracts.Authentication
{
    public record RegisterRequest(
        int BranchId,
        string UserName,
        string Password,
        string FullName,
        string Email,
        DateTime Dob,
        string Address,
        int Phone);
}
