using ApplicationFundamentals.Services;
using Microsoft.Extensions.Logging;
using ApplicationFundamentals.View;

namespace ApplicationFundamentals
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            // Register the service
            builder.Services.AddSingleton<IMyService, MyService>();
            // Register the StartPage
            builder.Services.AddTransient<StartPage>();

            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
