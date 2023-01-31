using Microsoft.Extensions.DependencyInjection;
using PawnShop.Application.Services.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
