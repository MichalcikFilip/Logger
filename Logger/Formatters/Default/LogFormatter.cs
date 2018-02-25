using Michalcik.Logger.Writers;
using System;

namespace Michalcik.Logger.Formatters.Default
{
    public class LogFormatter : BaseFormatter
    {
        public LogFormatter(IExceptionFormatter exceptionFormatter, params ILogWriter[] writers)
            : base(exceptionFormatter, writers)
        { }

        public override string Format(LogLevel level, DateTime time, string message, object source)
        {
            return $"{level} {time.ToString("G")} [{(source != null ? source.GetType().Name : "unknown")}]: {message}";
        }
    }
}
