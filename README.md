<div style="text-align:center">
 <img width="20%" src="https://github.com/enisn/Blazorius.Toast/blob/master/content/Blazorius_512.png?raw=true" />
 </div>
 
# Blazorius.Toast
A Generic Toast Implementation for Blazor. You can choose a toast implementation as your wish. So this library listens changes over `INotifyPropertyChanged` and `INotifyCollectionChanged`. So you just update your data ObservableCollection, and chart will be updated automaticly!

# Demo
See [live demo](https://enisn.github.io/Blazor.Toast-demo/)

# Support

| Package | Implementation | NuGet |
| --- | --- | --- |
| [Blazorius.Toast](https://www.nuget.org/packages/Blazorius.Toast/) | Abstractions | ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Blazorius.Toast?logo=nuget) |
| [Blazorius.Toast.Toastr](https://www.nuget.org/packages/Blazorius.Toast.Toastr/) | [CodeSeven/toastr](/CodeSeven/toastr) | ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Blazorius.Toast.Toastr?logo=nuget) |
| Blazorius.Toast.NativeToast | [egoist/native-toast](/egoist/native-toast) | ![](https://img.shields.io/nuget/vpre/Blazorius.Toast.NativeToast?logo=nuget) |
| [Blazorius.Toast.SiiimpleToast](https://www.nuget.org/packages/Blazorius.Toast.SiiimpleToast/) | [gomonk3037/siiimple-toast](/gomonk3037/siiimple-toast) | ![](https://img.shields.io/nuget/vpre/Blazorius.Toast.SiiimpleToast?logo=nuget) |



# Installation

- Add Nuget Package to your project.

_Choose one of implementation like below:_
_
```
Install-Package Blazorius.Toast.Toastr -Version 1.0.1
```

```
Install-Package Blazorius.Toast.SiiimpleToast -Version 1.0.1
```

- Go your **Startup.cs** and add your Toast implementation:

_Add one of implementation of toast like below:_
_
```csharp
 services.AddToastr(); // Add Toastr
 services.AddSiiimpleToast(); // or SiiimpleToast
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



