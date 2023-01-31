using Microsoft.Extensions.DependencyInjection;
using PawnShop.Application.Common.Interfaces.Authentication;
using PawnShop.Application.Services.Authentication;
using PawnShop.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure (this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            return services;

        }
    }
}
