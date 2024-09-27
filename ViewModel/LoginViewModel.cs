using LoginAuthMVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginAuthMVVM.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand ProcessLoginCommand { get; private set; }

        public LoginViewModel()
        {
            ProcessLoginCommand = new Command(
                execute: () => {
                    Shell.Current.Navigation.PushAsync(new Home());
                }
                );
        }


        private string postContent; 
        public string PostContent
        {
            get
            {
                return postContent;
            }
            set
            {
                postContent = value;
                OnPropertyChanged(nameof(PostContent));
            }
        }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }


        
    }
}
