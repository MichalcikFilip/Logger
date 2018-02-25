using System;

namespace Michalcik.Logger.Formatters.Default
{
    public class ExceptionFormatter : IExceptionFormatter
    {
        public string Format(Exception exception)
        {
            return exception?.Message + Environment.NewLine + exception?.StackTrace;
        }
    }
}
