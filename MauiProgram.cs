using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core.Handlers;

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
                    })

                    .ConfigureMauiHandlers(handlers =>
                        {
                            handlers.AddHandler<CommunityToolkit.Maui.Views.MediaElement, MediaElementHandler>(); // Register the handler
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

        private static void ConfigureMauiHandlers(Action<Microsoft.Maui.Hosting.IMauiHandlersCollection> value)
        {
            throw new NotImplementedException();
        }
    }
}
