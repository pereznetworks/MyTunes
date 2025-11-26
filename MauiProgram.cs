using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace MyTunes
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


                    #if ANDROID
                        builder.UseMauiCommunityToolkit()
                               .UseMauiCommunityToolkitMediaElement();
                    #else
                        builder.UseMauiCommunityToolkit();
                    #endif
                    
                    #if DEBUG   
                            builder.Logging.AddDebug();
                    #endif

                return builder.Build();
        }
    }
}
