using PawnShopBE.Core.Interfaces;
using PawnShopBE.Core.Models;
using Services.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class RoleService : IRoleService
    {
        public IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<bool> CreateRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRole(int roleId)
        {
            throw new NotImplementedException();
        }
    }
}
