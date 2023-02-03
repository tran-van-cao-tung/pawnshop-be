using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PawnShop.Application.Common.Interfaces.Authentication;
using PawnShop.Application.Common.Interfaces.Persistence;
using PawnShop.Application.Common.Interfaces.Services;
using PawnShop.Application.Services.Authentication;
using PawnShop.Infrastructure.Authentication;
using PawnShop.Infrastructure.Persistence;
using PawnShop.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure (
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;

        }
    }
}
