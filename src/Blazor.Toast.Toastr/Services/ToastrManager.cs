using Blazor.Toast.Abstractions;
using Blazor.Toast.Primitives;
using Blazor.Toast.Toastr.Extensions;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Toast.Toastr.Services
{
    public class ToastrManager : IToastManager
    {
        private const string SHOW_EVENT = "ShowToastrFromCs";
        private readonly IJSRuntime jSRuntime;

        public ToastrManager(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public Task ShowAsync(string message)
            => ShowAsync(Configuration.Default.Type, Configuration.Default.Position, message);


        public Task ErrorAsync(string message)
            => ShowAsync(ToastType.Error, Configuration.Default.Position, message);

        public Task InfoAsync(string message)
            => ShowAsync(ToastType.Info, Configuration.Default.Position, message);


        public async Task ShowAsync(ToastType type, ToastPosition position, string message)
            => await jSRuntime.InvokeVoidAsync(SHOW_EVENT, type.ToString().ToLowerInvariant(), position.ToClassName(), message);

        public Task SuccessAsync(string message)
            => ShowAsync(ToastType.Success, Configuration.Default.Position, message);

        public Task WarningAsync(string message)
            => ShowAsync(ToastType.Warning, Configuration.Default.Position, message);
    }
}
