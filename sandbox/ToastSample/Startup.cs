using Blazorius.Toast.Primitives;
using Blazorius.Toast.SiiimpleToast;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ToastSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSiiimpleToast(builder =>
            {
                builder.Position = ToastPosition.BottomCenter;
                builder.Type = ToastType.Success;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
