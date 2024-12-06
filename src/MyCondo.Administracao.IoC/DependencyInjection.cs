using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.CondominioService;
using MyCondo.Administracao.Application.Services.CondominioService.Interface;
using MyCondo.Administracao.Domain.Interface.Base;
using MyCondo.Administracao.Domain.Interface.Condominio;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Mappings.Condominio.Validator;
using MyCondo.Administracao.Infra.Repositories.Base;
using MyCondo.Administracao.Infra.Repositories.Condominio;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;

namespace MyCondo.Administracao.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<MyCondoContext>(options =>
        //    options.UseSqlite(
        //        configuration.GetConnectionString("DefaultConnection"),
        //        b => b.MigrationsAssembly("MyCondo.Administracao.API")));
        services.AddDbContext<MyCondoContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("MyCondo.Administracao.API")));


        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        ConfigurarAutoMapper(services);
        ConfiguraRepositories(services);
        ConfigureBaseService(services);
        ConfiguraServices(services);
        ConfiguraFLuentValidation(services);
        ConfigurarHealthCheck(services, configuration);
        ConfigurarCors(services, configuration);

        return services;
    }

    private static void ConfigurarCors(IServiceCollection services, IConfiguration configuration)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowLocalhost",
                policy => policy.WithOrigins(configuration.GetValue<string>("OriginAllow:url"))
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
        });
    }

    private static void ConfigurarHealthCheck(IServiceCollection services, IConfiguration configuration)
    {
        services.AddHealthChecks()
            .AddNpgSql(configuration.GetConnectionString("DefaultConnection"), name: "PostgreSQL");
            //.AddSqlite(configuration.GetConnectionString("DefaultConnection"), name: "Sqlite");

        services.AddHealthChecksUI(c =>
        {
            c.SetEvaluationTimeInSeconds(5);
            c.MaximumHistoryEntriesPerEndpoint(5);
            c.AddHealthCheckEndpoint("API HealthChecks", "/health");
        }).AddInMemoryStorage();
    }

    private static void ConfigurarAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CondominiosProfile));
        //services.AddAutoMapper(typeof(BlocosProfile));
        //services.AddAutoMapper(typeof(ApartamentoProfile));
        //services.AddAutoMapper(typeof(MoradoresProfile));
    }

    private static void ConfiguraServices(IServiceCollection services)
    {

        services.AddScoped<ICondominiosService, CondominiosService>();
        //services.AddScoped<IBlocosService, BlocosService>();
        //services.AddScoped<IApartamentosService, ApartamentosService>();
        //services.AddScoped<IMoradoresService, MoradoresService>();
    }

    private static void ConfigureBaseService(IServiceCollection services)
    {
        //services.AddScoped<IBaseService<MoradoresPesquisaRequest, MoradoresInserirRequest, MoradoresAtualizarRequest, MoradoresExcluirRequest, MoradoresResponse>, MoradoresService>();
        //services.AddScoped<IBaseService<BlocosPesquisaRequest, BlocosInserirRequest, BlocosAtualizarRequest, BlocosExcluirRequest, BlocosResponse>, BlocosService>();
        //services.AddScoped<IBaseService<ApartamentosPesquisaRequest, ApartamentosInserirRequest, ApartamentosAtualizarRequest, ApartamentosExcluirRequest, ApartamentosResponse>, ApartamentosService>();
        services.AddScoped<IBaseService<CondominiosPesquisaRequest, CondominiosInserirRequest, CondominiosAtualizarRequest, CondominiosExcluirRequest, CondominiosResponse>, CondominiosService>();
    }

    private static void ConfiguraRepositories(IServiceCollection services)
    {
        services.AddScoped<ICondominiosRepository, CondominiosRepository>();
        //services.AddScoped<IBlocosRepository, BlocoRepository>();
        //services.AddScoped<IApartamentosRepository, ApartamentosRepository>();
        //services.AddScoped<IMoradoresRepository, MoradoresRepository>();
    }

    private static void ConfiguraFLuentValidation(IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<CondominiosValidator>();
        //services.AddValidatorsFromAssemblyContaining<BlocosValidator>();
        //services.AddValidatorsFromAssemblyContaining<ApartamentosValidator>();
        //services.AddValidatorsFromAssemblyContaining<MoradoresValidator>();
    }
}

