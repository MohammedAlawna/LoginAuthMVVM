using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using LoginAuthMVVM.View;
using LoginAuthMVVM.ViewModel;
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
                    },
                    //UserRepos: includes methods for signing in, signing up, managing sessions for users.
                    UserRepository = new FileUserRepository("SecretMessage")
        }));

            //Adding Required Services (Singelton) to Views:
            //Adding Sign In Services:
            builder.Services.AddSingleton<FBSignIn>();
            builder.Services.AddSingleton<FBSignInViewModel>();

            //Adding Sign Up Services:
            builder.Services.AddSingleton<FBSignUp>();
            builder.Services.AddSingleton<FBSignUpViewModel>();
            


            return builder.Build();
        }
    }
}
