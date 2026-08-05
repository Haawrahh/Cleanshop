using MediatR;
using Cleanshop.domain.Interfaces;
using Cleanshop.infrastructure.Data;
using Cleanshop.infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Cleanshop.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Database
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Repository
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            // MediatR
               builder.Services.AddMediatR(typeof(Cleanshop.Application.Products.Commands.CreateProductCommand).Assembly);

            // API
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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

