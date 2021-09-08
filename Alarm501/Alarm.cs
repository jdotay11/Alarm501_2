using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public class Alarm
    {
        public DateTime time
        {
            get;
            set;
        }

        public AlarmStatus Status
        {
            get;
            set;
        }

        public Alarm(DateTime dt, bool running)
        {
            time = dt;

            if (running)
            {
                Status = AlarmStatus.RUNNING;
            }
            else
            {
                Status = AlarmStatus.STOPPED;
            }
        }

        public override string ToString()
        {
            string t = "ON";

            if(Status == AlarmStatus.STOPPED)
            {
                t = "OFF";
            }

            return time.ToString("h:mm tt") + "             " + t;
        }
    }
}
