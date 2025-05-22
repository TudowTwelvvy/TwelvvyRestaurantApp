using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TwelvvyRestaurantApp.Data;

namespace TwelvvyRestaurantApp
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
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();

            builder.Services.AddSingleton<DatabaseService>();
#endif

            return builder.Build();
        }
    }
}
