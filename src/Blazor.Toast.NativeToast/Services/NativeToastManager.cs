using Blazor.Toast.Abstractions;
using Blazor.Toast.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Toast.NativeToast.Services
{
    public class NativeToastManager : IToastManager
    {
        public Task ErrorAsync(string message)
        {
            throw new NotImplementedException();
        }

        public Task InfoAsync(string message)
        {
            throw new NotImplementedException();
        }

        public Task ShowAsync(ToastType type, ToastPosition position, string message)
        {
            throw new NotImplementedException();
        }

        public Task ShowAsync(string message)
        {
            throw new NotImplementedException();
        }

        public Task SuccessAsync(string message)
        {
            throw new NotImplementedException();
        }

        public Task WarningAsync(string message)
        {
            throw new NotImplementedException();
        }
    }
}
