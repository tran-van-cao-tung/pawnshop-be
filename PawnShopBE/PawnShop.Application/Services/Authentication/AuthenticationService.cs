using PawnShop.Application.Common.Interfaces.Authentication;
using PawnShop.Application.Common.Interfaces.Persistence;
using PawnShop.Domain.Entities;
using PawnShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks; 

namespace PawnShop.Application.Services.Authentication
{
    
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;   
        }

        
       

        
        public AuthenticationResult Register(int branchId, string userName, string password, string fullName, string email, DateTime dob, string address, int phone)
        {
            // 1. Validate the user doesn't exist
            
            if (_userRepository.GetUserByEmail(email ) != null)
            {
                throw new Exception("User with given email already exists.");
            }
            var user = new User
            {
                BranchId = branchId,
                UserName = userName,
                Password = password,
                FullName = fullName,
                Email = email,
                Dob = dob,
                Address = address,
                Phone = phone,
                CreateDate = DateTime.Now,
                LastModifiedDate = null,
                Status = (int)UserStatus.Active
            };
            // 2. create user (generate unique ID)

            // create JWT token

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }

        public AuthenticationResult Login(string userName, string password)
        {      
            // 1. Validate the user exists
            if (_userRepository.GetUserByUserName(userName) is not User user)
            {
                throw new Exception("User with given email does not exists.");
            }
            // 2. Validate the password is correct
            if (user.Password != password)
            {
                throw new Exception("Invalid password.");
            }
            // 3. Create JWT token
            var token = _jwtTokenGenerator.GenerateToken(user);
            return new AuthenticationResult(user, token);
        }   
    }
}
