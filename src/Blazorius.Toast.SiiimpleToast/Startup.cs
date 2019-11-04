using Blazorius.Toast.Abstractions;
using Blazorius.Toast.SiiimpleToast.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blazorius.Toast.SiiimpleToast
{
    public static class Startup
    {
        public static IServiceCollection AddSiiimpleToast(this IServiceCollection services, Action<Configuration> builder = null)
        {
            builder?.Invoke(Configuration.Default);
            return services
                .AddSingleton<SiiimpleToastManager>()
                .AddSingleton<IToastManager>(sp => sp.GetService<SiiimpleToastManager>());
        }
    }
}
