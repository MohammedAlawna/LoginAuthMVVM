using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginAuthMVVM.ViewModel
{
    public class HomeViewModel: ViewModelBase
    {
        public ICommand GetDateTimeCommand { get; private set; }

        public HomeViewModel()
        {
            GetDateTimeCommand = new Command(
                execute: () =>
                { 
                    //Show Current DateTime:
                    DateTime dateTimeRef = new DateTime();

                    //This will output the default value => 1/1/0001 12:00:00 AM
                    Debug.WriteLine(dateTimeRef);

                    //Minimum Value:
                    Debug.WriteLine(DateTime.MinValue);

                    //Maximum Value:
                    Debug.WriteLine(DateTime.MaxValue);
                }
                );
            
        }
    }
}
