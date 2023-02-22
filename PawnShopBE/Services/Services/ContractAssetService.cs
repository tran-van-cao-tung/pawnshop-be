using PawnShopBE.Core.Interfaces;
using PawnShopBE.Core.Models;
using Services.Services.IServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ContractAssetService : IContractAssetService
    {
        public IUnitOfWork _unitOfWork;

        public ContractAssetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateContractAsset(ContractAsset contractAsset)
        {
            if (contractAsset != null)
            {
                await _unitOfWork.ContractAssets.Add(contractAsset);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteContractAsset(int contractAssetId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContractAsset>> GetAllContractAssets()
        {
            throw new NotImplementedException();
        } 

        public async Task<ContractAsset> GetContractAssetById(int contractAssetId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateContractAsset(ContractAsset contractAsset)
        {
            throw new NotImplementedException();
        }
    }
}
