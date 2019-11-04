using Blazorius.Toast.Abstractions;
using Blazorius.Toast.Primitives;
using Blazorius.Toast.SiiimpleToast.Extensions;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Toast.SiiimpleToast.Services
{
    public class SiiimpleToastManager : IToastManager
    {
        private const string SHOW_EVENT = "ShowSiiimpleFromCs";
        private readonly IJSRuntime jSRuntime;

        public SiiimpleToastManager(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public Task ShowAsync(string message)
               => ShowAsync(Configuration.Default.Type, Configuration.Default.Position, message);

        public Task ErrorAsync(string message)
            => ShowAsync(ToastType.Error, Configuration.Default.Position, message);

        public Task InfoAsync(string message)
            => ShowAsync(ToastType.Info, Configuration.Default.Position, message);

        public Task SuccessAsync(string message)
            => ShowAsync(ToastType.Success, Configuration.Default.Position, message);

        public Task WarningAsync(string message)
            => ShowAsync(ToastType.Warning, Configuration.Default.Position, message);

        public async Task ShowAsync(ToastType type, ToastPosition position, string message) 
            => await jSRuntime.InvokeVoidAsync(SHOW_EVENT, type.ToJsParameter(), position.ToJsParameter(), message);
    }
}
