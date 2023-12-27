
using AutoMapper;
using Ecommerce.ProductService.Mappings;
using Ecommerce.ProductService.Repository;
using Ecommerce.ProductService.Services;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IProductService, EStoreProductService>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddAutoMapper(typeof(MappingProfiles));
            builder.Services.AddDbContext<ProductDBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ProductServiceDB"));
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
