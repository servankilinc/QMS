using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QMS.VirtualTerminal.ViewModels;
using QMS.VirtualTerminal.Views;
using System.Windows;

namespace QMS.VirtualTerminal;

public partial class App : Application
{
    public static IHost? AppHost { get; private set; }
    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {                
                // ViewModels
                services.AddSingleton<HomeVM>();
                services.AddSingleton<MainWindowVM>();

                // Views
                services.AddSingleton<Home>();
                services.AddSingleton<MainWindow>();
            })
            .Build();
    }


    protected override async void OnStartup(StartupEventArgs e)
    {
        if (AppHost is null) throw new InvalidOperationException("AppHost is not initialized.");

        await AppHost.StartAsync();

        var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        if (AppHost is not null)
        {
            await AppHost.StopAsync();
            AppHost.Dispose();
        }

        base.OnExit(e);
    }
}
