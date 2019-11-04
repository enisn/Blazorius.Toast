using Blazorius.Toast.Primitives;

namespace Blazorius.Toast
{
    public class Configuration
    {
        public static Configuration Default { get; } = new Configuration();

        public ToastPosition Position { get; set; }

        public ToastType Type { get; set; } = ToastType.Info;
    }
}
