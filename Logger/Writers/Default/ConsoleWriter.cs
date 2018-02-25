using System;

namespace Michalcik.Logger.Writers.Default
{
    public class ConsoleWriter : ILogWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
