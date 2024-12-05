using MyCondo.Administracao.IoC;
using MyCondo.Administracao.IoC.HealthCheck;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});


builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyCondo Administra��o v1");
        c.DocExpansion(DocExpansion.None);
    });
}

app.UseCors("AllowLocalhost");

app.UseCustomHealthChecks();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
