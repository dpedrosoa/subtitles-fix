// See https://aka.ms/new-console-template for more information
using SubtitlesFixLibrary.FileOperations;
using SubtitlesFixLibrary.Model;

Console.WriteLine("Hello and Welcome to the Subtitle Fix Application!");

// path = {project folder} \TestFiles";
string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\TestFiles"));
string fileName = "text-es.srt";
string filePath = $@"{path}\{fileName}";

string newFileName = "NewSubtitle.srt";
string newFilePath = $@"{path}\{newFileName}";

List<SubtitleModel> subtitles = FileReadWrite.ReadSubtitles(filePath);

FileReadWrite.WriteAllSubtitles(subtitles, newFilePath);

Console.ReadLine();