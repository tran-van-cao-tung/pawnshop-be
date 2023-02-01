using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PawnShop.Application.Common.Interfaces.Authentication;
using PawnShop.Application.Common.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Infrastructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtSettings _jwtSetting;

        private readonly IDateTimeProvider _dateTimeProvider;

        public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
        {
            _dateTimeProvider = dateTimeProvider;
            _jwtSetting = jwtOptions.Value;
        }

        public string GenerateToken(Guid userId, string firstName, string lastName)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtSetting.Secret)), 
                SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim (JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim (JwtRegisteredClaimNames.GivenName, firstName),
                new Claim (JwtRegisteredClaimNames.FamilyName, lastName),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var securityToken = new JwtSecurityToken(
                issuer: _jwtSetting.Issuer,
                audience: _jwtSetting.Audience,
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSetting.ExpiryMinutes),
                claims: claims); ;

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}