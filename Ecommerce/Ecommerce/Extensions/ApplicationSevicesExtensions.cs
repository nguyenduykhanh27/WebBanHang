using Ecommerce.Application.Implementation;
using Ecommerce.Application.Interfaces;
using Ecommerce.Data.EF;
using Ecommerce.Data.EF.Repositories;
using Ecommerce.Data.IRepositories;
using Ecommerce.Errors;
using Ecommerce.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Ecommerce.Extensions
{
    public static class ApplicationSevicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            // Repository
            services.AddScoped(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddScoped(typeof(IRepository<,>), typeof(EFRepository<,>));
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
       

            // Services
            services.AddScoped<ITokenService, TokenService>();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState
                    .Where(e => e.Value.Errors.Count > 0)
                    .SelectMany(x => x.Value.Errors)
                    .Select(x => x.ErrorMessage).ToArray();

                    var errorResponse = new ApiValidationErrorResponse
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });
            return services;
        }
    }
}
