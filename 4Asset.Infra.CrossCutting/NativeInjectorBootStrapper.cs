using _4Asset.Application;
using _4Asset.Application.Interfaces;
using _4Asset.Domain.Interfaces.Repositories;
using _4Asset.Domain.Interfaces.Services;
using _4Asset.Domain.Services;
using _4Asset.Infra.Data.Context;
using _4Asset.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace _4Asset.Infra.CrossCutting
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
