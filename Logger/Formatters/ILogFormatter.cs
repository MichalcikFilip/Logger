using Michalcik.Logger.Writers;
using System;
using System.Collections.Generic;

namespace Michalcik.Logger.Formatters
{
    public interface ILogFormatter
    {
        IExceptionFormatter ExceptionFormatter { get; }
        IEnumerable<ILogWriter> Writers { get; }

        string Format(LogLevel level, DateTime time, string message, object source);
    }
}
