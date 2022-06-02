using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Library
{
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     gets current UTC Time as a unixtime long
        /// </summary>
        /// <returns>Unix time</returns>
        public static long ToUnixTime(this DateTime datetime)
        {
            var epoch = (long)(datetime.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            if (epoch < 0)
                epoch = 0;
            return epoch;
        }

        /// <summary>
        /// Converts a unix timestamp to a DateTime
        /// </summary>
        /// <param name="time">Unix timestamp</param>
        /// <returns>DateTime</returns>
        public static DateTime FromUnixTime(long time)
        {
            return (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(time);
        }
    }
}
