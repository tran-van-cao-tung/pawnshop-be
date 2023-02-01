using PawnShop.Application.Common.Interfaces.Authentication;
using PawnShop.Application.Common.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
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

        
       

        
        public AuthenticationResult Register(string firstName, string lastName, string email, string password)

        // 1. Validate the user doesn't exist

        // 2. create user (generate unique ID)

        // create JWT token

        {
            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }

        public AuthenticationResult Login(string email, string password)
        {         
            return new AuthenticationResult(Guid.NewGuid(),"firstName", "lastName", email, "token");
        }
    }
}
