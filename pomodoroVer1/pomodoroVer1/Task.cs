using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace pomodoroVer1
{
    class Task
    {
        private Timer workTimer;
        private Timer breakTimer;
        private int _completedCycles;

        public Task() { }
        public Task(int workMins, int breakMins)
        {
            workTimer = new Timer(workMins);
            breakTimer = new Timer(breakMins);

            workTimer.TimerFinished += WorkTimerFinished;
            breakTimer.TimerFinished += BreakTimerFinished;
        }

        public void Start() => workTimer.Start();

        private void WorkTimerFinished(object sender, EventArgs e)
        {
            WriteLine("Work time is over. Take a break!");
            breakTimer.Start();
        }

        private void BreakTimerFinished(object sender, EventArgs e)
        {
            _completedCycles++;
            WriteLine($"Break time is over. Completed cycles: {_completedCycles}. Time to work!");
            workTimer.Start();
        }
    }
}
