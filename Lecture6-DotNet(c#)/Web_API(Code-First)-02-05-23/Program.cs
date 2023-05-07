using Web_API_Code_First__02_05_23.Models;
using Microsoft.EntityFrameworkCore;


namespace Web_API_Code_First__02_05_23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<HospitalDbContext>(options => options.UseSqlServer("Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;trustservercertificate=true"));
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