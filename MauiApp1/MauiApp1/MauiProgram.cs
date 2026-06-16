using MauiApp1.Services;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;
using Plugin.LocalNotification.Core.Models.AndroidOption;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            
            var builder = MauiApp.CreateBuilder();
            builder.Services.AddSingleton<DataService>();
            builder
                .UseMauiApp<App>()
                .UseLocalNotification(config =>
                {
                    config.AddAndroid(android =>
                    {
                        // Default channel for general notifications
                        android.AddChannel(new AndroidNotificationChannelRequest
                        {
                            Id = "general_channel",
                            Name = "General",
                            Description = "General notifications",
                            Importance = AndroidImportance.Default
                        });

                        // High-priority channel for important alerts
                        android.AddChannel(new AndroidNotificationChannelRequest
                        {
                            Id = "urgent_channel",
                            Name = "Important Alerts",
                            Description = "Critical notifications that require immediate attention",
                            Importance = AndroidImportance.High,
                            EnableVibration = true,
                            EnableLights = true,
                            LightColor = new AndroidColor { ResourceName = "red" }
                        });

                        // Silent channel for background updates
                        android.AddChannel(new AndroidNotificationChannelRequest
                        {
                            Id = "silent_channel",
                            Name = "Silent Updates",
                            Description = "Background updates and non-urgent information",
                            Importance = AndroidImportance.Low,
                            EnableVibration = false,
                            EnableSound = false
                        });
                    });
                });
            builder.ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
