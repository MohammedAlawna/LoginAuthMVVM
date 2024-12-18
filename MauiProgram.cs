using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;

namespace LoginAuthMVVM
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
    		builder.Logging.AddDebug();
#endif
            //Firebase Auth: Integration
            builder.Services.AddSingleton(new FirebaseAuthClient
                (new FirebaseAuthConfig()
                {
                    ApiKey = "AIzaSyAaahksGmC2M1IpC2gKmIY0DBIQcBqZInA",
                    AuthDomain = "kudo1-38995.firebaseapp.com",
                    Providers = new FirebaseAuthProvider[]
                    {
                    new EmailProvider()
                    }
                }));
            return builder.Build();
        }
    }
}
