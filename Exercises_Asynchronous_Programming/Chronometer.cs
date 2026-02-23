using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Asynchronous_Programming
{
    public class Chronometer : IChronometer
    {
        private Stopwatch stopwatch;
        private List<string> laps;

        public Chronometer()
        {
            this.stopwatch = new Stopwatch();
            this.laps = new List<string>();
        }

        public string GetTime => stopwatch.Elapsed.ToString(@"mm\:ss\:ffff");

        public List<string> Laps => this.laps;

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public string Lap()
        {
            string currentTime = this.GetTime;
            this.laps.Add(currentTime);
            return currentTime;
        }

        public void Reset()
        {
            stopwatch.Reset();
            laps.Clear();
        }
    }
}
