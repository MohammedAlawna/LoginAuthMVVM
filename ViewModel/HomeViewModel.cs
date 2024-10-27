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
        public ICommand GetTimeDiffAlgorithm { get; private set; }

        public HomeViewModel()
        {
            ProcessDateTimeCommand();
            GetTimeOnlyCmd();

            GetTimeDiffAlgorithm = new Command(
                execute: () =>
                {
                    //IMP:: Get Time Diff after adding, then countdown:
                    //1- Get Current Time:
                    //var currentDateTime = DateTime.UtcNow;
                    //Debug.Write("Current DateTime: " + currentDateTime);

                    //2- Parse Time to add, add it to original time (new var)
                    //TimeSpan to be added => (0 days, 7 hours, 00 seconds, 0000 milliseconds).
                    //TimeSpan twelveHoursTimeSpan = TimeSpan.Parse("0:7:00:00.0000");
                    //Debug.WriteLine("Time To Be Added To Cureent Time: " + twelveHoursTimeSpan);

                    //var timeWithAddedDuration = currentDateTime.Add(twelveHoursTimeSpan);
                    //Debug.WriteLine("New Time With Original: " + timeWithAddedDuration);

                    //3- Get Difference of CurrentTime and NewAddedTime:
                    //var timeDifference = timeWithAddedDuration.Subtract(currentDateTime);
                   // Debug.WriteLine("Time Difference: " + timeDifference);

                    //4- TODO: Countdown timer tick:
//Stopwatch stopwatch = new Stopwatch();
  //                  stopwatch.Start();
                    //var stopwatchElapsed = timeDifference.Subtract(stopwatch.Elapsed);
    //                for(int i = 0; i<10; i++)
      //              {
        //                Debug.WriteLine($"Stopwatch Tracker: {stopwatch.Elapsed.TotalSeconds}");
          //          }

                    //Testing New Algorithm
                    //1- Get Current Time:
                    var currentDateTime = DateTime.UtcNow;
                    Debug.Write("Current DateTime: " + currentDateTime);

                    //2- Add 7 Hours to Current Time:
                    TimeSpan sevenHoursTimeSpan = TimeSpan.Parse("0:7:00:00.0000");
                    var targetDateTime = currentDateTime.Add(sevenHoursTimeSpan);
                    Debug.WriteLine("Target DateTime: " + targetDateTime);

                    //3- Check If Time Is The New one:
                    //If Yes => Room can be added.
                    if(targetDateTime == DateTime.UtcNow)
                    {
                        Debug.WriteLine("System is Ok! Players can create next duel room!");
                    }
                    if(targetDateTime != DateTime.UtcNow)
                    {
                        Debug.WriteLine("System Denied the duel! Players can't create room until 7 hours has passed to their last duel.");
                    }

                    //If not => Room cnnot be added until time is the new one (added 7 h)

                }
                );
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
