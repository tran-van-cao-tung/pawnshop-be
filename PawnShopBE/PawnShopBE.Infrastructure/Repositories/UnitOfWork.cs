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

        public ILedgerRepository Ledgers => throw new NotImplementedException();

        public IInterestDiaryRepository InterestDiaries => throw new NotImplementedException();

        public IContractRepository Contracts => throw new NotImplementedException();

        public IKycRepository Kycs => throw new NotImplementedException();

        public IPackageRepository Packages => throw new NotImplementedException();

        public ILiquidationRepository Liquidations => throw new NotImplementedException();

        public ICustomerRepository Customers => throw new NotImplementedException();

        public IContractAssetRepository ContractAssets => throw new NotImplementedException();

        public IPawnableProductRepository PawnableProduct => throw new NotImplementedException();

        public IAttributeRepository Attributes => throw new NotImplementedException();

        public IWarehouseRepository Warehouses => throw new NotImplementedException();

        public IDependentPeopleRepository DependentPeople => throw new NotImplementedException();

        public IJobRepository Jobs => throw new NotImplementedException();

        public ICustomerRelativeRelationshipRepository CustomersRelativeRelationships => throw new NotImplementedException();

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
