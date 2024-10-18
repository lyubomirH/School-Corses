using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class DateCounter
    {
        public int CalculateDiffrence(string date1, string date2)
        {
            var date1Arr = new DateTime((date1.Split("/").Select(int.Parse).ToArray())[0],
                (date1.Split("/").Select(int.Parse).ToArray())[1],
                (date1.Split("/").Select(int.Parse).ToArray())[2]
                );

            var date2Arr = new DateTime((date2.Split("/").Select(int.Parse).ToArray())[0],
                (date2.Split("/").Select(int.Parse).ToArray())[1],
                (date2.Split("/").Select(int.Parse).ToArray())[2]
                );

            return Math.Abs((date2Arr - date1Arr).Days);
        }
    }
}
