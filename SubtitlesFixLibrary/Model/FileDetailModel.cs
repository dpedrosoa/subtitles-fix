using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesFixLibrary.Model
{
    public class FileDetailModel
    {
        /// <summary>
        /// Name of the file without the extension
        /// Ex: filename
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Extension of the file including the leading dot
        /// Ex: .srt
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Name of the file including the extension.
        /// Ex: filename.srt
        /// </summary>
        public string NameWithExtension { get; set; }

        /// <summary>
        /// Directory's full path of the file without the file name
        /// Ex: D:Data\Test
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Directory's full path of the file including the file name and extension
        /// Ex: D:Data\Test\filename.srt
        /// </summary>
        public string FullPathName { get; set; }

    }
}
