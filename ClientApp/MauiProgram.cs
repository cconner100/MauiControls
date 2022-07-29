namespace ClientApp
{
    using ClientApp.Handlers;
    using ClientApp.UserControls;


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
                    handlers.AddHandler<ZtWebTabViewItemView, ZtWebTabViewItemViewHandler>();
                    handlers.AddHandler<ZtNavigationView, ZtNavigationViewHandler>();
                    handlers.AddHandler<ZtWebTabView, ZtWebTabViewHandler>();
#if MACCATALYST
                    handlers.AddHandler<DtShell, DtShellHandler>();
#endif
                });

            return builder.Build();
        }
    }
}
