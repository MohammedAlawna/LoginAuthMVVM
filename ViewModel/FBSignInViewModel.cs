using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
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
        private readonly FirebaseAuthClient _authClient;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        /*  [ObservableProperty]
          private string _username;*/

        public string Username => _authClient.User?.Info?.DisplayName;

        public FBSignInViewModel(FirebaseAuthClient authClient)
        {
            _authClient = authClient;
            
        }

        [RelayCommand]
        public async Task FBSignIn()
        {
            await _authClient.SignInWithEmailAndPasswordAsync(Email, Password);
            OnPropertyChanged(nameof(Username));
        }


        [RelayCommand]
        public async Task NavigateFBSignUp()
        {
            await Shell.Current.Navigation.PushAsync(new FBSignUp(_authClient));
        }
    }
}
