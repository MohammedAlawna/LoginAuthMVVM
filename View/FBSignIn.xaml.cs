using Firebase.Auth;
using LoginAuthMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LoginAuthMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FBSignIn : ContentPage
    {
       // private readonly FirebaseAuthClient _authClient;
        public FBSignIn(/*FirebaseAuthClient authClient*/)
        {
            
            InitializeComponent();
           // _authClient = authClient;
            BindingContext = new FBSignInViewModel(/*_authClient*/);
        }
    }
}