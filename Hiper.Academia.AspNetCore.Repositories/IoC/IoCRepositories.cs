﻿using Hiper.Academia.AspNetCore.Repositories.ContasBancarias;
using Hiper.Academia.AspNetCore.Repositories.MovimentacoesBancarias;
using Microsoft.Extensions.DependencyInjection;

namespace Hiper.Academia.AspNetCore.Repositories.IoC
{
    public class IoCRepositories
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IContaBancariaRepository, ContaBancariaRepository>();
            services.AddScoped<IMovimentacaoBancariaRepository, MovimentacaoBancariaRepository>();
        }
    }
}