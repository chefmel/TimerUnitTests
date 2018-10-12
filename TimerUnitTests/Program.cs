using System;
using System.Timers;

namespace TimerApp14_3
{
    public class Program
    {
        private static System.Timers.Timer aTimer;
        public static void Main(string[] args)
        {
            try
            {


                //Create a basic timer application that lets 
                //the user set a timer in minutes, seconds, 
                //hours or a combination thereof.Think of it 
                //as a command line version of setting a timer 
                //through Siri or an Amazon Echo.Try to make it 
                //as flexible as possible to all kinds of crazy 
                //input command.Make sure to document your program
                //well with comments and create the proper classes
                //and objects. Don’t forget your new error handling skills.
                //Upload your program to a new repository call CG 11 - 3
                SetTimer();

                Console.WriteLine("\npress the Enter key to exit the application...\n");
                Console.WriteLine("There application started at {0:HH:mm:ss.fff}", DateTime.Now);
                Console.ReadLine();
                aTimer.Stop();
                aTimer.Dispose();

                Console.WriteLine("Terminating the application...");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Incorrect format");
            }
        }
        private static void SetTimer()
        {
            //create a timer with a 2 second interval
            aTimer = new System.Timers.Timer(2000);
            //hook up the elapsed event for the timer
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
