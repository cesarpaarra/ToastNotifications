```
████████╗ ██████╗  █████╗ ███████╗████████╗██╗███████╗██╗   ██╗
╚══██╔══╝██╔═══██╗██╔══██╗██╔════╝╚══██╔══╝██║██╔════╝╚██╗ ██╔╝
   ██║   ██║   ██║███████║███████╗   ██║   ██║█████╗   ╚████╔╝ 
   ██║   ██║   ██║██╔══██║╚════██║   ██║   ██║██╔══╝    ╚██╔╝  
   ██║   ╚██████╔╝██║  ██║███████║   ██║   ██║██║        ██║   
   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝   ╚═╝   ╚═╝╚═╝        ╚═╝   
                                                               
```

# Toastify
#### Toast notifications for WPF

Toastify allows you to create and display notifications in WPF applications.


[![Nuget install](https://img.shields.io/badge/nuget-install-green.svg)](https://www.nuget.org/packages/Toastify/)


### 1. Install via nuget:
[ToastNotifications](https://www.nuget.org/packages/Toastify/)

```
Install-Package Toastify
```

### 2. Create ToastViewModel class
```csharp
using Toastify;

Notifier notifier = new Notifier(cfg =>
{
    cfg.PositionProvider = new WindowPositionProvider(
        parentWindow: Application.Current.MainWindow,
        corner: Corner.TopRight,
        offsetX: 10,  
        offsetY: 10);

    cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
        notificationLifetime: TimeSpan.FromSeconds(3),
        maximumNotificationCount: MaximumNotificationCount.FromCount(5));

    cfg.Dispatcher = Application.Current.Dispatcher;
});
```

### 3. Use provided messages
```csharp
using Toastify;

notifier.ShowInformation(message);
notifier.ShowSuccess(message);
notifier.ShowWarning(message);
notifier.ShowError(message);
```


## Documentation

* [Relesae notes](https://github.com/cesarpaarra/ToastNotifications/blob/master/Docs/ReleaseNotes.md)
  Release notes, description of new features, bug fixes and breaking changes.
  
## Creating new issues
Before you create new issue, please check the documentation, because many features and options are already there.
(https://github.com/cesarpaarra/ToastNotifications/tree/master/Docs)

If there is still a problem, please create new issue/question filling following informations. 
If it's possible, please provide a sample code to reproduce issue.

## Contributors
Toastify represents a significant evolution of the original ToastNotifications library. This project has been developed as a fork of its previous version, and it has been specifically designed to be compatible with and take advantage of the features of the newer versions of .NET, starting from .NET 7 onwards.

During the development of Toastify, we have preserved the essence and main functionality of ToastNotifications, while also making significant updates to adapt it to modern development practices in the latest versions of .NET. In addition, we have conducted a review and made slight modifications to the library's structure, aiming to optimize its efficiency, scalability, and ease of use.

We wish to express our deepest gratitude and recognition to the original authors of ToastNotifications for their vision and dedication in creating such a valuable tool. Their efforts have laid the groundwork for the development of Toastify. Furthermore, we thank all those who have contributed to the initial project and its subsequent versions. Their contributions have been fundamental in shaping this new version.
