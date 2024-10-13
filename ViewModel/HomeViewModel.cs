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
        public ICommand GetTimeOnly { get; private set; }
        public ICommand AddSevenHours { get; private set; }

        public ICommand GetTimeDifference { get; private set; }
        public HomeViewModel()
        {
            ProcessDateTimeCommand();
            GetTimeOnlyCmd();
        }

        private void GetTimeOnlyCmd()
        {
            GetTimeOnly = new Command(
                            execute: () =>
                            {
                                //Time Only Operations:
                                //Get Current Time only: 
                                TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
                                Debug.WriteLine("Get Current Time: " + timeOnly);
                            }
                            );
        }

        private void ProcessDateTimeCommand()
        {
            GetDateTimeCommand = new Command(
                            execute: () =>
                            {
                                //Show Current DateTime:
                                DateTime dateTimeRef = new DateTime();

                                //This will output the default value => 1/1/0001 12:00:00 AM
                                Debug.WriteLine("Default Value: " + dateTimeRef);

                                //Minimum Value:
                                Debug.WriteLine("Min Value: " + DateTime.MinValue);

                                //Maximum Value:
                                Debug.WriteLine("Max Value: " + DateTime.MaxValue);

                                //Get Local CurrentDateTime:
                                Debug.WriteLine("Local DateTime: " + DateTime.Now);

                                //Get Universal CurrentDateTime:
                                Debug.WriteLine("Universal DateTime: " + DateTime.UtcNow);
                            }
                            );
        }
    }
}
