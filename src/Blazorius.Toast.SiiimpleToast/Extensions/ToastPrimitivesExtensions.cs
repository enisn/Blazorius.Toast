using Blazorius.Toast.Primitives;

namespace Blazorius.Toast.SiiimpleToast.Extensions
{
    public static class ToastPrimitivesExtensions
    {
        public static string ToJsParameter(this ToastPosition position)
        {
            switch (position)
            {
                case ToastPosition.TopRight:
                    return "top|right";
                case ToastPosition.BottomRight:
                    return "bottom|right";
                case ToastPosition.BottomLeft:
                    return "bottom|left";
                case ToastPosition.TopLeft:
                    return "top|left";
                case ToastPosition.TopFullWidth:
                case ToastPosition.TopCenter:
                    return "top|center";
                case ToastPosition.BottomFullWidth:
                case ToastPosition.BottomCenter:
                    return "bottom|center";
            }

            return default;
        }

        public static string ToJsParameter(this ToastType type)
        {
            switch (type)
            {
                case ToastType.None:
                case ToastType.Info:
                    return "message";
                case ToastType.Success:
                    return "success";
                case ToastType.Warning:
                case ToastType.Error:
                    return "alert";
            }
            return "message";
        }
    }
}
