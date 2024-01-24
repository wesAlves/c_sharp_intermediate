using System;

namespace Modulo_02
{
    internal partial class Program
    {
        private class Stopwatch
        {
            //This class should implment a stopwatch that
            //Must be able to start counting time
            //Must be stop to start counting time
            //When stoped should be able to call the diference between start and stoped
            //Must not be able to start when already started


            private DateTime startedTime { get; set; }

            private DateTime stopedTime { get; set; }

            public DateTime StartTimer
            {
                get => startedTime = DateTime.Now;
            }

            public DateTime StopTimer
            {
                get => stopedTime = DateTime.Now;
            }

            public TimeSpan SpentTime => stopedTime - startedTime;

            public bool IsRunning => startedTime < stopedTime;
        }
    }
}