using SubtitlesFixLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesFixLibrary.Model
{
    public class SubtitleModel
    {
        public int Id { get; set; }
        public TimeSpan StartTimeSpan { get; set; }
        public TimeSpan EndTimeSpan { get; set; }
        public string TimeString { private get; set; }
        public List<string> Text { get; set; } = new List<string>();

        public SubtitleModel()
        {

        }
        public SubtitleModel(int id)
        {
            Id = id;
        }

        public string GetTimeString()
        {
            try
            {
                string startTime = TimeSpanHelper.CreateStringFromTimeSpan(StartTimeSpan);

                string endTime = TimeSpanHelper.CreateStringFromTimeSpan(EndTimeSpan);

                return startTime + " --> " + endTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return TimeString;
            }

        }

    }
}
