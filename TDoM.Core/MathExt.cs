using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public static class MathExt
    {
        public static double Clamp(this double value, double min, double max)
        {
            if(value < min)
            {
                value = min;
            }
            else if(value > max)
            {
                value = max;
            }
            return value;
        }
    }
}
