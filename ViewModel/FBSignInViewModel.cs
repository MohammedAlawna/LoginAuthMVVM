using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
//using Firebase.Auth.Providers;
using LoginAuthMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthMVVM.ViewModel
{
    public partial class FBSignInViewModel : ObservableObject
    {
       // private readonly FirebaseAuthClient _authClient;
        
         

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        /*  [ObservableProperty]
          private string _username;*/

       // public string Username => _authClient.User?.Info?.DisplayName;

        public FBSignInViewModel(/*FirebaseAuthClient authClient*/)
        {
           // _authClient = authClient;
            
        }

        //Reset Password/ForgetPassword with Firebase =>
        [RelayCommand]
        public async Task SendPasswordResetEmail(string email)
        {
          //  await _authClient.ResetEmailPasswordAsync(email);
        }

       
        [RelayCommand]
        public async Task FBSignIn()
        {
            //await _authClient.SignInWithEmailAndPasswordAsync(Email, Password);
           // _authClient.Sen
          //  OnPropertyChanged(nameof(Username));
        }


        [RelayCommand]
        public async Task NavigateFBSignUp()
        {
            await Shell.Current.Navigation.PushAsync(new FBSignUp(/*_authClient*/));
        }
    }

    //Interface: Access Token Purposes (Secret Message):
  /*  public interface IGetSecretMessageQuery
    {
        //Note: to complete this you need to install refit, refit.httpclientfactory
        [Get("/")]
        Task<SecretMessageResponse> Execute();
    }*/

}
