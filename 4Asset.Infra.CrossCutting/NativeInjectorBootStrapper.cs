using FourAsset.Application;
using FourAsset.Application.Interfaces;
using FourAsset.Domain.Interfaces.Repositories;
using FourAsset.Domain.Interfaces.Services;
using FourAsset.Domain.Services;
using FourAsset.Infra.Data.Context;
using FourAsset.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FourAsset.Infra.CrossCutting
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            services.AddScoped<ITarefaAppService, TarefaAppService>();
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddScoped<ITarefaRepository, TarefaRepository>();

            services.AddDbContext<FourAssetContext>();
        }
    }
}
