using Firebase.Auth;
using LoginAuthMVVM.View;

namespace LoginAuthMVVM
{
    public partial class App : Application
    {
        const string firbaseAPIkey = "AIzaSyAaahksGmC2M1IpC2gKmIY0DBIQcBqZInA";

        public static FirebaseAuthProvider authProvider = new FirebaseAuthProvider(new FirebaseConfig(firbaseAPIkey));
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
