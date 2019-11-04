using Blazor.Toast.Primitives;
using Blazor.Toast.Toastr;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ToastSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddToastr(builder => builder.Position = ToastPosition.BottomCenter);
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
