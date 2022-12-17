using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal abstract class Old
    {
        int PriceDownValue = 35;

        

        public int PriceDownCalculation(int _pathYear)
        {
            return PriceDownValue * _pathYear;
        }
       
    }
}
