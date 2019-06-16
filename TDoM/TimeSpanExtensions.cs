using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM
{
    public static class TimeSpanExtensions
    {
        public static string GetAudioTimeStamp(this TimeSpan ts)
        {
            StringBuilder res = new StringBuilder();
            if(ts.Hours != 0)
            {
                res.Append(ts.Hours.ToString("D2"));
                res.Append(":");
            }
            res.Append(ts.Minutes.ToString("D2"));
            res.Append(":");
            res.Append(ts.Seconds.ToString("D2"));
            return res.ToString();
        }
    }
}
