# Blazorius.Toast
A Generic Toast Implementation for Blazor. You can choose a toast implementation as your wish.

# Demo
See [live demo](https://enisn.github.io/Blazor.Toast-demo/)

# Support

| Package | Implementation | NuGet |
| --- | --- | --- |
| [Blazorius.Toast](https://www.nuget.org/packages/Plugin.Blazorius.Toast/) | Abstractions | ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Plugin.Blazorius.Toast?logo=nuget) |
| [Blazorius.Toast.Toastr](https://www.nuget.org/packages/Blazorius.Toast.Toastr/) | [CodeSeven/toastr](/CodeSeven/toastr) | ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Plugin.Blazorius.Toast.Toastr?logo=nuget) |
| Blazorius.Toast.NativeToast | [egoist/native-toast](/egoist/native-toast) | ![](https://img.shields.io/nuget/vpre/Plugin.Blazorius.Toast.NativeToast?logo=nuget) |
| Blazorius.Toast.SiiimpleToast | [gomonk3037/siiimple-toast](/gomonk3037/siiimple-toast) | ![](https://img.shields.io/nuget/vpre/Plugin.Blazorius.Toast.SiiimpleToast?logo=nuget) |



# Installation

- Add Nuget Package to your project.

```
Install-Package Plugin.Blazorius.Toast.Toastr -Version 1.0.0
```

- Go your **Startup.cs** and add your Toast implementation:

```csharp
 services.AddToastr();
```

- You can customize default values:


```csharp 
public void ConfigureServices(IServiceCollection services)
{
    services.AddToastr(builder =>
    {
        builder.Position = ToastPosition.BottomCenter;
        builder.Type = ToastType.Success;
    });
}
```


# Usage

- Go your view and add following using:

- Inject `IToastManager`

- And use methods over **IToastManager**


```razor

@page "/"

@using Blazorius.Toast.Abstractions

@inject IToastManager Toast;

<button @onclick="ShowToast">Click me!</button>

@code {

    async Task ShowToast()
    {
        await Toast.ShowAsync("Hello World!");
    }
}
```



