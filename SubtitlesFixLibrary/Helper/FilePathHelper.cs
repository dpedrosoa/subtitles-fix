using SubtitlesFixLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesFixLibrary.Helper
{
    public static class FilePathHelper
    {
        public static FileDetailModel GetNewFileDetail(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                {
                    FileDetailModel fileDetail = new FileDetailModel();

                    string name = fileInfo.Name.Split('.')[0];

                    fileDetail.Name = $"{name}-fixed";
                    fileDetail.Extension = fileInfo.Extension;
                    fileDetail.Path = fileInfo.DirectoryName;

                    fileDetail.NameWithExtension = $"{fileDetail.Name}{fileDetail.Extension}";
                    fileDetail.FullPathName = $@"{fileDetail.Path}\{fileDetail.NameWithExtension}";

                    return fileDetail;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        } 
    }
}
