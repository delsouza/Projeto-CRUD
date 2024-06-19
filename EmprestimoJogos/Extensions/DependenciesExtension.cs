using EmprestimoJogos.Context;
using System;

namespace EmprestimoJogos.Extensions
{
    public static class DependenciesExtension
    {
        public static void AddDbContexts(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
        }
    }
}

