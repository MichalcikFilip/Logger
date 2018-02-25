using Michalcik.Logger.Formatters;
using Michalcik.Logger.Writers;
using System;
using System.Collections.Generic;

namespace Michalcik.Logger
{
    public class BaseLogger
    {
        public LogLevel MinLevel { get; set; } = LogLevel.Debug;
        public List<ILogFormatter> Formatters { get; } = new List<ILogFormatter>();

        public void Message(LogLevel level, string message, object source)
        {
            DateTime time = DateTime.Now;

            if (CanLogMessage(level, source))
                foreach (ILogFormatter formatter in Formatters)
                    Write(formatter.Format(level, time, message, source), formatter.Writers);
        }

        public void Exception(LogLevel level, Exception exception, object source)
        {
            DateTime time = DateTime.Now;

            if (CanLogMessage(level, source))
                foreach (ILogFormatter formatter in Formatters)
                    Write(formatter.Format(level, time, formatter.ExceptionFormatter?.Format(exception), source), formatter.Writers);
        }

        protected virtual bool CanLogMessage(LogLevel level, object source)
        {
            return level >= MinLevel;
        }

        private void Write(string message, IEnumerable<ILogWriter> writers)
        {
            foreach (ILogWriter writer in writers)
                writer.Write(message);
        }

        public void Debug(string message, object source)
        {
            Message(LogLevel.Debug, message, source);
        }

        public void Debug(Exception exception, object source)
        {
            Exception(LogLevel.Debug, exception, source);
        }

        public void Info(string message, object source)
        {
            Message(LogLevel.Info, message, source);
        }

        public void Info(Exception exception, object source)
        {
            Exception(LogLevel.Info, exception, source);
        }

        public void Warning(string message, object source)
        {
            Message(LogLevel.Warning, message, source);
        }

        public void Warning(Exception exception, object source)
        {
            Exception(LogLevel.Warning, exception, source);
        }

        public void Error(string message, object source)
        {
            Message(LogLevel.Error, message, source);
        }

        public void Error(Exception exception, object source)
        {
            Exception(LogLevel.Error, exception, source);
        }
    }
}
