using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACTest1
{
    public class MTimmer
    {
        private Thread timerThread;
        private Stopwatch stopWatch;
        public bool IsStart = false;
        public long TimeCount;
        public long Interval;

        public MTimmer(long t)
        {
            Interval = t;
        }   

        public void Start()
        {
            IsStart = true;
            timerThread = new Thread(new ThreadStart(timerThreadFunction));
            timerThread.Start();
            timerThread.Join();
        }

        private void timerThreadFunction()
        {
            stopWatch = Stopwatch.StartNew();
            while (IsStart)
            {
                Thread.Sleep(100);
                TimeCount = stopWatch.ElapsedMilliseconds;

                if (TimeCount >= Interval)
                {
                    stopWatch.Stop();
                    TimeCount = 0;
                    IsStart = false;
                }
            }
        }

        public void SetTimmer(long t)
        {
            Interval = t;
        }
        public bool IsTimeOut()
        {
            return !IsStart;
        }
    }
}
