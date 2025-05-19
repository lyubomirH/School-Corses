using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGN_Program
{
    public interface IEGNDataProvider
    {
        string GetRegionName(int regionCode);
    }
}
