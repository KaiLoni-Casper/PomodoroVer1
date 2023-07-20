using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace pomodoroVer1
{
    class Thing
    {
        private int inter;
        private Thing timer;

        public event EventHandler TimerFinished;

        public Thing(int interval)
        {
            inter = interval;
            if (interval > 1000)
                timer = new Timer(interval* 1000);

            timer.Elapsed += Timer_Elapsed;
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            TimerFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}
