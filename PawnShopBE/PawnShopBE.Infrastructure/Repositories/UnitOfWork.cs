using PawnShopBE.Core.Interfaces;
using PawnShopBE.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShopBE.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        public IUserRepository Users { get; }

        public IBranchRepository Branches { get; }

        public IRoleRepository Roles { get; }

        public UnitOfWork(  DbContextClass dbContext,
                            IUserRepository userRepository, 
                            IBranchRepository branchRepository,
                            IRoleRepository roleRepository)
        {
            _dbContext = dbContext;
            Users = userRepository;
            Branches = branchRepository;
            Roles = roleRepository;

        }

     
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
