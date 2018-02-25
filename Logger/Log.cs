using Michalcik.Logger.Formatters;
using Michalcik.Logger.Formatters.Default;
using Michalcik.Logger.Writers.Default;
using System;
using System.Collections.Generic;

namespace Michalcik.Logger
{
    public static class Log
    {
        public static BaseLogger Logger { get; } = new BaseLogger();

        public static void Configure(LogLevel minLevel, string path)
        {
            Logger.MinLevel = minLevel;
            Logger.Formatters.Clear();
            Logger.Formatters.Add(new LogFormatter(new ExceptionFormatter(), new ConsoleWriter(), new FileWriter(path)));
        }

        public static void Configure(LogLevel minLevel, IEnumerable<ILogFormatter> formatters)
        {
            Logger.MinLevel = minLevel;
            Logger.Formatters.Clear();
            Logger.Formatters.AddRange(formatters);
        }

        public static void Debug(string message, object source)
        {
            Logger.Debug(message, source);
        }

        public static void Debug(Exception exception, object source)
        {
            Logger.Debug(exception, source);
        }

        public static void Info(string message, object source)
        {
            Logger.Info(message, source);
        }

        public static void Info(Exception exception, object source)
        {
            Logger.Info(exception, source);
        }

        public static void Warning(string message, object source)
        {
            Logger.Warning(message, source);
        }

        public static void Warning(Exception exception, object source)
        {
            Logger.Warning(exception, source);
        }

        public static void Error(string message, object source)
        {
            Logger.Error(message, source);
        }

        public static void Error(Exception exception, object source)
        {
            Logger.Error(exception, source);
        }
    }
}
