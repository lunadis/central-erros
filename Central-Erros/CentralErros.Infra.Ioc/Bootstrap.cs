using CentralErros.Application;
using CentralErros.Application.App;
using CentralErros.Application.Interface;
using CentralErros.Data;
using CentralErros.Data.Repository;
using CentralErros.Domain.Interfaces;
using CentralErros.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Xml.Schema;

namespace CentralErros.Infra.Ioc
{
    public static class Bootstrap
    {
        public static void RegistrarServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IAplicacaoRepositorio, AplicacaoRepository>();
            services.AddScoped<IAvisoRepositorio, AvisoRepository>();
            services.AddScoped<ILogRepositorio, LogRepository>();
            services.AddScoped<ITipoLogRepositorio, TipoLogRepository>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepository>();
            services.AddScoped<IUsuarioAplicacaoRepositorio, UsuarioAplicacaoRepository>();
            services.AddScoped<IUsuarioAvisoRepositorio, UsuarioAvisoRepository>();

            services.AddScoped<IAplicacaoApp, AplicacaoApp>();
            services.AddScoped<IAvisoApp, AvisoApp>();
            services.AddScoped<ILogApp, LogApp>();
            services.AddScoped<ITipoLogApp, TipoLogApp>();
            services.AddScoped<IUsuarioAplicacaoApp, UsuarioAplicacaoApp>();
            services.AddScoped<IUsuarioApp, UsuarioApp>();
            services.AddScoped<IUsuarioAvisoApp, UsuarioAvisoApp>();




            services.AddDbContext<Contexto>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LuisDB")));
        }
    }
}
