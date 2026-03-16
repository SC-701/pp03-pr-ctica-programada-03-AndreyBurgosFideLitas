
using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using DA;
using Flujo;
using Vehiculo.Abstracciones.Interfaces.DA;
using Vehiculo.Abstracciones.Interfaces.Flujo;
using Vehiculo.DA;
using Vehiculo.DA.Repositorios;
using Vehiculo.Flujo;

namespace Vehiculo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IVehiculoFlujo, VehiculoFlujo>();
            builder.Services.AddScoped<IVehiculoDA, VehiculoDA>();
            builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();
            builder.Services.AddScoped<IMarcaFlujo, MarcaFlujo>();
            builder.Services.AddScoped<IMarcaDA, MarcaDA>();
            builder.Services.AddScoped<IModeloFlujo, ModeloFlujo>();
            builder.Services.AddScoped<IModeloDA, ModeloDA>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
