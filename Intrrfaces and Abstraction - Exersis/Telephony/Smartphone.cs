using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : IBrowsable, ICallable
    {
        public string Number { get; set; }
        public string Sites { get; set; }
        public Smartphone(string number, string sites)
        {
            number = Number;
            sites = Sites;
        }
        public string Brows()
        {
            return $"Calling...{Number}";
        }

        public string Call()
        {
            return $"Browsing: {Sites}";
        }
    }
}
