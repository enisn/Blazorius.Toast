using Blazorius.Toast.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazorius.Toast.Toastr.Extensions
{
    public static class ToastPositionExtensions
    {
        public static string ToClassName(this ToastPosition position)
        {
            switch (position)
            {
                case ToastPosition.TopRight:
                    return "toast-top-right";
                case ToastPosition.BottomRight:
                    return "toast-bottom-right";
                case ToastPosition.BottomLeft:
                    return "toast-bottom-left";
                case ToastPosition.TopLeft:
                    return "toast-top-left";
                case ToastPosition.TopFullWidth:
                    return "toast-top-full-width";
                case ToastPosition.BottomFullWidth:
                    return "toast-bottom-full-width";
                case ToastPosition.TopCenter:
                    return "toast-top-center";
                case ToastPosition.BottomCenter:
                    return "toast-bottom-center";
            }

            return default;
        }
    }
}
