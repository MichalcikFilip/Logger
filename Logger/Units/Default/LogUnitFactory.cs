using Michalcik.Logger.Formatters;
using Michalcik.Logger.Writers;
using System.Collections.Generic;

namespace Michalcik.Logger.Units.Default
{
    public class LogUnitFactory : ILogUnitFactory
    {
        public ILogUnit Create(ILogFormatter formatter, IEnumerable<ILogWriter> writers)
        {
            if (formatter != null && writers != null)
                return new LogUnit(formatter, writers);

            return null;
        }
    }
}
