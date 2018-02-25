using Michalcik.Logger.Writers;
using System;
using System.Collections.Generic;

namespace Michalcik.Logger.Formatters
{
    public abstract class BaseFormatter : ILogFormatter
    {
        public IExceptionFormatter ExceptionFormatter { get; }
        public IEnumerable<ILogWriter> Writers { get; } = new List<ILogWriter>();

        public BaseFormatter(IExceptionFormatter exceptionFormatter, params ILogWriter[] writers)
        {
            ExceptionFormatter = exceptionFormatter;
            ((List<ILogWriter>)Writers).AddRange(writers);
        }

        public abstract string Format(LogLevel level, DateTime time, string message, object source);
    }
}
