using System;
using System.IO;

namespace Michalcik.Logger.Writers.Default
{
    public class FileWriter : ILogWriter
    {
        public string Path { get; set; }

        public FileWriter(string path)
        {
            Path = path;
        }

        public void Write(string message)
        {
            try
            {
                File.AppendAllText(Path, message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
