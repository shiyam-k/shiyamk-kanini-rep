using Intern_Explorer.Auth;
using Intern_Explorer.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);



        // Add services to the container.
        builder.Services.AddControllersWithViews();

        ConfigurationManager configuration = builder.Configuration;

        builder.Services.AddScoped<IRepoIC, RepoIC>();

        builder.Services.AddDbContext<InternDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("connection")));

        
        // For Identity
        /*builder.Services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<InternDBContext>()
            .AddDefaultTokenProviders();*/

        // Adding Authentication
        /*builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })*/

        // Adding Jwt Bearer
        /*.AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = configuration["JWT:ValidAudience"],
                ValidIssuer = configuration["JWT:ValidIssuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
            };
        });*/


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication(); // will not be avaialable

        app.UseAuthorization();//by default, this code will be avaialbale


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Login}/{action=LoginView}/{id?}");

        app.Run();
    }
}