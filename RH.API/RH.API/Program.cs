using Microsoft.EntityFrameworkCore;
using RH.API.Extensions.SwaggerConfigurations;
using RH.MySQL.MySQL;

namespace RH.API;
public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("RHConnection");

        builder.Services.AddDbContext<MySQLContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        builder.Services.AddSwaggerConfig(builder.Configuration).AddControllers();

        var app = builder.Build();

        app.UsePathBase("/rh-api");

        app.UseRouting();

        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "RH API V1");
            options.RoutePrefix = string.Empty; // Define a URL base para acessar o Swagger
        });

        app.MapControllers();
        await app.RunAsync();
    }
}
