using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
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
        private readonly FirebaseAuthClient _authClient;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        public FBSignUpViewModel(FirebaseAuthClient authClient)
        {
            _authClient = authClient;
            
        }

        [RelayCommand]
        public async Task FBSignUp()
        {
            Debug.WriteLine("You just signed Up!");
            await _authClient.CreateUserWithEmailAndPasswordAsync(Email, Password, Username);
            await Shell.Current.Navigation.PushAsync(new FBSignIn(_authClient));
        }

        [RelayCommand]
        public async Task NavigateFBSignIn()
        {
            await Shell.Current.Navigation.PushAsync(new FBSignIn(_authClient));
        }
    }
}
