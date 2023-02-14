using PawnShopBE.Core.Interfaces;
using PawnShopBE.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateUser(User user)
        {
            if (user   != null)
            {
                await _unitOfWork.Users.Add(user);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteUser(Guid userId)
        {
            if (userId != null)
            {
                var user = await _unitOfWork.Users.GetById(userId);
                if (user != null)
                {
                    _unitOfWork.Users.Delete(user);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var userList = await _unitOfWork.Users.GetAll();
            return userList;
        }

        public async Task<User> GetUserById(Guid userId)
        {
            if (userId != null)
            {
                var user = await _unitOfWork.Users.GetById(userId);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<bool> UpdateUser(User user)
        {
            if (user != null)
            {
                var userUpdate = await _unitOfWork.Users.GetById(user.userId);
                if (userUpdate != null)
                {
                    userUpdate.userName = user.userName;
               
                    _unitOfWork.Users.Update(userUpdate);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
