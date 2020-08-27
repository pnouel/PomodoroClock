using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroClock
{
    public class timerPomodoro
    {
        private string Hours;
        private string Minutes;
        private string Seconds;

 
        private TimeSpan thisTimeSpan;

        public timerPomodoro(TimeSpan timeSpan)
        {
            thisTimeSpan = timeSpan;
        }

        public string hours()
        {

            Hours = thisTimeSpan.Hours.ToString().Length < 2 ? "0" + thisTimeSpan.Hours.ToString() : thisTimeSpan.Hours.ToString();

            return Hours;
        }
        public string minutes()
        {
            Minutes = thisTimeSpan.Minutes.ToString().Length < 2 ? "0" + thisTimeSpan.Minutes.ToString() : thisTimeSpan.Minutes.ToString();
            return Minutes;
        }
        public string seconds()
        {
            Seconds = thisTimeSpan.Seconds.ToString().Length < 2 ? "0" + thisTimeSpan.Seconds.ToString() : thisTimeSpan.Seconds.ToString();
            return Seconds;
        }
  

    }
}
