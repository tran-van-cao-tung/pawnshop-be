using PawnShopBE.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attribute = PawnShopBE.Core.Models.Attribute;

namespace Services.Services.IServices
{
    public interface IAttributeService
    {
        Task<bool> CreateAttribute(Attribute branch);

        Task<IEnumerable<Branch>> GetAllBranch();

        Task<Branch> GetBranchById(int branchId);

        Task<bool> UpdateBranch(Branch branch);

        Task<bool> DeleteBranch(int branchId);
    }
}
