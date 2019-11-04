using Blazor.Toast.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Toast.Abstractions
{
    public interface IToastManager
    {
        Task ShowAsync(ToastType type, ToastPosition position, string message);

        Task ShowAsync(string message);

        Task SuccessAsync(string message);

        Task InfoAsync(string message);

        Task ErrorAsync(string message);

        Task WarningAsync(string message);
    }
}
