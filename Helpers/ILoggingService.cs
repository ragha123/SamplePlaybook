using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook
{
    public interface ILoggingService
    {
        void LogMessage(string message);
    }
}
