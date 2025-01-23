using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using FirebaseAdmin.Auth;
using LoginAuthMVVM.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LoginAuthMVVM.ViewModel
{
    public partial class FBSignUpViewModel: ObservableObject
    {
        //private readonly FirebaseAuthClient _authClient;
        FirebaseAuthProvider _provider;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        public FBSignUpViewModel(/*FirebaseAuthClient authClient*/)
        {
           // _authClient = authClient;
            _provider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAaahksGmC2M1IpC2gKmIY0DBIQcBqZInA"));
            
        }

        [RelayCommand]
        public async Task SendVerificationEmail(string email)
        {
         
         
          
            //Add firebaseadmin package (nuget package)
            //await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync("alawnehmmuhammad6@gmail.com");
        }


        [RelayCommand]
        public async Task FBSignUp()
        {
           var authUser =  await _provider.CreateUserWithEmailAndPasswordAsync(Email, Password, Username);
            await _provider.SendEmailVerificationAsync(authUser.FirebaseToken);
            //await _authClient.CreateUserWithEmailAndPasswordAsync(Email, Password, Username);
        
            //await auth.GenerateEmailVerificationLinkAsync(Email); ;
         
         //   var currentUser = await FirebaseAuth.DefaultInstance.user

           // await FirebaseAuth.DefaultInstance.GenerateEmailVerificationLinkAsync(EmailV);
           
            
            
            await Shell.Current.Navigation.PushAsync(new FBSignIn(/*_authClient*/));
        }

        [RelayCommand]
        public async Task NavigateFBSignIn()
        {
            await Shell.Current.Navigation.PushAsync(new FBSignIn(/*_authClient*/));
        }
    }
}
