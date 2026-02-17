using Microsoft.Extensions.Logging;
using DataLoggerViewer.Presentation.Services;

namespace DataLoggerViewer
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddScoped<IDateState, DateState>();
            builder.Services.AddScoped<ILiftSummaryService, LiftSummaryService>();
            builder.Services.AddSingleton<IDlogDirectoryService, DlogDirectoryService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}

