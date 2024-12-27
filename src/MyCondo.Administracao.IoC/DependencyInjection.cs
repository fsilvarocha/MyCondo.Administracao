using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCondo.Administracao.Application.Services.ApartamentoService;
using MyCondo.Administracao.Application.Services.ApartamentoService.Interface;
using MyCondo.Administracao.Application.Services.AreaComunService;
using MyCondo.Administracao.Application.Services.AreaComunService.Interface;
using MyCondo.Administracao.Application.Services.Base;
using MyCondo.Administracao.Application.Services.BlocoService;
using MyCondo.Administracao.Application.Services.BlocoService.Interface;
using MyCondo.Administracao.Application.Services.CondominioService;
using MyCondo.Administracao.Application.Services.CondominioService.Interface;
using MyCondo.Administracao.Application.Services.MoradorService;
using MyCondo.Administracao.Application.Services.MoradorService.Interface;
using MyCondo.Administracao.Application.Services.VagaGaragem;
using MyCondo.Administracao.Application.Services.VagaGaragem.Interface;
using MyCondo.Administracao.Domain.Interface.Apartamento;
using MyCondo.Administracao.Domain.Interface.AreaComun;
using MyCondo.Administracao.Domain.Interface.Base;
using MyCondo.Administracao.Domain.Interface.Bloco;
using MyCondo.Administracao.Domain.Interface.Condominio;
using MyCondo.Administracao.Domain.Interface.Morador;
using MyCondo.Administracao.Domain.Interface.VagaGaragem;
using MyCondo.Administracao.Infra.Data;
using MyCondo.Administracao.Infra.Mappings.Apartamento.Validator;
using MyCondo.Administracao.Infra.Mappings.AreaComun.Validator;
using MyCondo.Administracao.Infra.Mappings.Bloco.Validator;
using MyCondo.Administracao.Infra.Mappings.Condominio.Validator;
using MyCondo.Administracao.Infra.Mappings.Morador.Validator;
using MyCondo.Administracao.Infra.Mappings.VagaGaragem.Validator;
using MyCondo.Administracao.Infra.Repositories.Apartamento;
using MyCondo.Administracao.Infra.Repositories.AreaComun;
using MyCondo.Administracao.Infra.Repositories.Base;
using MyCondo.Administracao.Infra.Repositories.Bloco;
using MyCondo.Administracao.Infra.Repositories.Condominio;
using MyCondo.Administracao.Infra.Repositories.Morador;
using MyCondo.Administracao.Infra.Repositories.VagaGaragem;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Apartamento.Response;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Request;
using MyCondo.Administracao.Transfer.DataTransfer.AreaComun.Response;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Bloco.Response;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Condominio.Response;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Request;
using MyCondo.Administracao.Transfer.DataTransfer.Morador.Response;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Profiles;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Request;
using MyCondo.Administracao.Transfer.DataTransfer.VagaGaragem.Response;

namespace MyCondo.Administracao.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MyCondoContext>(options =>
            options.UseSqlite(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("MyCondo.Administracao.API")));
        //services.AddDbContext<MyCondoContext>(options =>
        //    options.UseSqlServer(
        //        configuration.GetConnectionString("DefaultConnection"),
        //        b => b.MigrationsAssembly("MyCondo.Administracao.API")));


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
           // .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "SqlServer");
            .AddSqlite(configuration.GetConnectionString("DefaultConnection"), name: "Sqlite");

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
        services.AddAutoMapper(typeof(BlocosProfile));
        services.AddAutoMapper(typeof(ApartamentoProfile));
        services.AddAutoMapper(typeof(MoradoresProfile));
        services.AddAutoMapper(typeof(VagasGaragemProfile));
    }

    private static void ConfiguraServices(IServiceCollection services)
    {

        services.AddScoped<ICondominiosService, CondominiosService>();
        services.AddScoped<IBlocosService, BlocosService>();
        services.AddScoped<IApartamentosService, ApartamentosService>();
        services.AddScoped<IMoradoresService, MoradoresService>();
        services.AddScoped<IAreaComunsService, AreaComunsService>();
        services.AddScoped<IVagasGaragemService, VagasGaragemService>();
    }

    private static void ConfigureBaseService(IServiceCollection services)
    {
        services.AddScoped<IBaseService<MoradoresPesquisaRequest, MoradoresInserirRequest, MoradoresAtualizarRequest, MoradoresExcluirRequest, MoradoresResponse>, MoradoresService>();
        services.AddScoped<IBaseService<BlocosPesquisaRequest, BlocosInserirRequest, BlocosAtualizarRequest, BlocosExcluirRequest, BlocosResponse>, BlocosService>();
        services.AddScoped<IBaseService<ApartamentosPesquisaRequest, ApartamentosInserirRequest, ApartamentosAtualizarRequest, ApartamentosExcluirRequest, ApartamentosResponse>, ApartamentosService>();
        services.AddScoped<IBaseService<CondominiosPesquisaRequest, CondominiosInserirRequest, CondominiosAtualizarRequest, CondominiosExcluirRequest, CondominiosResponse>, CondominiosService>();
        services.AddScoped<IBaseService<AreaComunsPesquisaRequest, AreaComunsInserirRequest, AreaComunsAtualizarRequest, AreaComunsExcluirRequest, AreaComunsResponse>, AreaComunsService>();
        services.AddScoped<IBaseService<VagasGaragemPesquisaRequest, VagasGaragemInserirRequest, VagasGaragemAtualizarRequest, VagasGaragemExcluirRequest, VagasGaragemResponse>, VagasGaragemService>();
    }

    private static void ConfiguraRepositories(IServiceCollection services)
    {
        services.AddScoped<ICondominiosRepository, CondominiosRepository>();
        services.AddScoped<IBlocosRepository, BlocoRepository>();
        services.AddScoped<IApartamentosRepository, ApartamentosRepository>();
        services.AddScoped<IMoradoresRepository, MoradoresRepository>();
        services.AddScoped<IAreaComunsRepository, AreaComunsRepository>();
        services.AddScoped<IVagasGaragemRepository, VagasGaragemRepository>();
    }

    private static void ConfiguraFLuentValidation(IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<CondominiosValidator>();
        services.AddValidatorsFromAssemblyContaining<BlocosValidator>();
        services.AddValidatorsFromAssemblyContaining<ApartamentosValidator>();
        services.AddValidatorsFromAssemblyContaining<MoradoresValidator>();
        services.AddValidatorsFromAssemblyContaining<AreaComunsValidator>();
        services.AddValidatorsFromAssemblyContaining<VagasGaragemValidator>();
    }
}

