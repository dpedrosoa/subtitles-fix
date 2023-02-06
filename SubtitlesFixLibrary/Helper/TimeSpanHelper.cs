using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesFixLibrary.Helper
{
    public static class TimeSpanHelper
    {
        /// <summary>
        /// Creates a TimeSpan from a string 
        /// </summary>
        /// <param name="timeText">
        ///     A string representation of a TimeSpan in the format "hh:mm:ss,fff"
        /// </param>
        /// <returns></returns>
        public static TimeSpan CreateTimeSpanFromString(string timeText)
        {
            string[] time = timeText.Split(',');
            string timeString = time[0];
            string milisecondsString = time.Length > 1 ? time[1] : string.Empty;

            var timeSpan = new TimeSpan();
            bool timeValid = TimeSpan.TryParse(timeString, out timeSpan);
            if (timeValid && !string.IsNullOrEmpty(milisecondsString))
            {
                int miliseconds;
                bool msecValid = int.TryParse(milisecondsString, out miliseconds);
                if (msecValid)
                {
                    timeSpan = new TimeSpan(
                        timeSpan.Days,
                        timeSpan.Hours,
                        timeSpan.Minutes,
                        timeSpan.Seconds,
                        miliseconds
                        );
                }
            }

            return timeSpan;
        }

        /// <summary>
        /// Creates a string from a TimeSpan
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public static string CreateStringFromTimeSpan(TimeSpan timeSpan)
        {
            string timeString = timeSpan.ToString().Replace('.', ',');
            if (timeSpan.Milliseconds > 0)
            {
                timeString = timeString.Substring(0, timeString.Length - 4);
            }
            else
            {
                timeString += ",000";
            }
            return timeString;
        }
    }
}
