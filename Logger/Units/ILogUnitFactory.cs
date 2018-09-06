using Michalcik.Logger.Formatters;
using Michalcik.Logger.Writers;
using System.Collections.Generic;

namespace Michalcik.Logger.Units
{
    public interface ILogUnitFactory
    {
        ILogUnit Create(ILogFormatter formatter, IEnumerable<ILogWriter> writers);
    }
}
