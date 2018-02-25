using System;

namespace Michalcik.Logger.Formatters
{
    public interface IExceptionFormatter
    {
        string Format(Exception exception);
    }
}
