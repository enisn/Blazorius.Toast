using Blazor.Toast.Abstractions;
using Blazor.Toast.Toastr.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blazor.Toast.Toastr
{
    public static class Startup
    {
        public static IServiceCollection AddToastr(this IServiceCollection services, Action<Configuration> builder = null)
        {
            builder?.Invoke(Configuration.Default);
            return services
                .AddSingleton<ToastrManager>()  // If multiple implementation added into service collection, they can be resolved by directly type instead of interface.
                .AddSingleton<IToastManager>(sp => sp.GetService<ToastrManager>());
        }
    }
}
