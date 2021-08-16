using System;
using System.Text;
using Core.Entities.Identity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            var builder = services.AddIdentityCore<AppUser>(Opt =>
           {
               Opt.Password.RequiredLength = 3;
               Opt.Password.RequireDigit = true;
               Opt.Password.RequireNonAlphanumeric = false;

               Opt.Lockout.MaxFailedAccessAttempts = 3;
               Opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

               Opt.SignIn.RequireConfirmedEmail = true;
           });
            builder = new IdentityBuilder(builder.UserType, builder.Services);
            builder.AddEntityFrameworkStores<StoreContext>();
            builder.AddSignInManager<SignInManager<AppUser>>();
            builder.AddDefaultTokenProviders();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
                        ValidIssuer = config["Token:Issuer"],
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            return services;
        }
    }
}