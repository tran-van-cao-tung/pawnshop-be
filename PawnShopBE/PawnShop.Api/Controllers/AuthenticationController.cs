using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using PawnShop.Application.Services.Authentication;
using PawnShop.Contracts.Authentication;
using PawnShop.Domain.Entities;
using System.Net;
using System.Numerics;
using IAuthenticationService = PawnShop.Application.Services.Authentication.IAuthenticationService;

namespace PawnShop.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            
            var authResult = _authenticationService.Register(request.BranchId, request.UserName, request.Password, request.FullName, request.Email, request.Dob, request.Address, request.Phone);
            var response = new AuthenticationResponse(authResult.User,authResult.Token);
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(authResult.User, authResult.Token);
            return Ok(response);
        }

    }
}
