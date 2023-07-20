using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;
namespace pomodoroVer1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pomodoro timer");

            int workMins = 25;
            int breakMins = 5;

            var pomodoro = new Task(workMins, breakMins);
            pomodoro.Start();

            WriteLine("Press any key to exit the timer");
            ReadKey();
        }
    }
}
