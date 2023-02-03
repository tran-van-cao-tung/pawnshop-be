using PawnShop.Application.Common.Interfaces.Persistence;
using PawnShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Infrastructure.Persistence
{
    public  class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }

        public User? GetUserByUserName(string userName)
        {
            return _users.SingleOrDefault(u => u.UserName == userName);
        }
    }
}
