using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Asynchronous_Programming
{
    public interface IChronometer
    {
        public string GetTime { get; }
        List<string> Laps { get; }
        void Start();
        void Stop();
        string Lap();
        void Reset();

    }
}
