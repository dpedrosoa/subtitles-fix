using SubtitlesFixLibrary.Helper;
using SubtitlesFixLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesFixLibrary.FileOperations
{
    public static class FileReadWrite
    {
        /// <summary>
        /// Reads all the subtitles in a file
        /// </summary>
        /// <param name="filePath">
        ///     The path of the file to read including filename and extension
        /// </param>
        /// <returns>
        ///     The list of subtitles of type SubtitleModel
        /// </returns>
        public static List<SubtitleModel> ReadSubtitles(string filePath)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Opening file: " + filePath);
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(filePath);

            Console.WriteLine("Reading file...");

            string[] allLines = File.ReadAllLines(filePath);
            Console.WriteLine("Total lines: " + allLines.Length);

            List<SubtitleModel> allSubtitles = new List<SubtitleModel>();
            // Previous Subtitle Details
            SubtitleModel previousSubtitle = new SubtitleModel();

            int i = 0;

            for (i = 0; i < allLines.Length; i++)
            {
                var line = allLines[i];
                // Check if is a new subtitle id
                int id;
                bool validId = int.TryParse(line, out id);
                if (validId)
                {
                    //Console.Write("#: " + id);

                    SubtitleModel subtitle = new SubtitleModel(id);

                    i++;// time line
                    line = allLines[i];
                    subtitle.TimeString = line;

                    // check timestamp
                    var times = line.Split(" --> ");
                    if (times.Length > 0)
                    {
                        string startTime = times[0];
                        TimeSpan startTimeSpan = TimeSpanHelper.CreateTimeSpanFromString(startTime);

                        string endTime = times[1];
                        TimeSpan endTimeSpan = TimeSpanHelper.CreateTimeSpanFromString(endTime);

                        // update previous subtitle's end time
                        previousSubtitle.EndTimeSpan = startTimeSpan;

                        // set current subtitle times
                        subtitle.StartTimeSpan = startTimeSpan;
                        subtitle.EndTimeSpan = endTimeSpan;
                    }

                    // Read subtitle text lines
                    i++;// next line
                    while (i < allLines.Length)
                    {
                        line = allLines[i];
                        subtitle.Text.Add(line);
                        if (line == "") // empty line is the break for next subtitle
                        {
                            break;
                        }
                        i++;
                    }
                    allSubtitles.Add(subtitle);
                    previousSubtitle = subtitle;

                    //Console.WriteLine("... End " + id);
                }
            }
            Console.WriteLine("Finish reading all subtitles");
            Console.WriteLine("-----------------------------");

            return allSubtitles;
        }


        /// <summary>
        /// Writes all the subtitles in the list to a file
        /// </summary>
        /// <param name="subtitles">
        ///     The list subtitles to write in the file
        /// </param>
        /// <param name="filePath">
        ///     The path of the file to write including file name and extension
        /// </param>
        public static void WriteAllSubtitles(List<SubtitleModel> subtitles, string filePath)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Opening file: " + filePath);

            StreamWriter writer = new StreamWriter(filePath);
            Console.WriteLine("Writing file.");

            foreach (SubtitleModel subtitle in subtitles)
            {
                writer.WriteLine(subtitle.Id);
                writer.WriteLine(subtitle.GetTimeString());
                foreach (var text in subtitle.Text)
                {
                    writer.WriteLine(text);
                }
            }
            writer.Close();
            Console.WriteLine("Finish writing all subtitles.");
            Console.WriteLine("-----------------------------");

        }
    }
}
