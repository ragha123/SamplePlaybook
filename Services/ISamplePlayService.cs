using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook.Services
{
    public interface ISamplePlayService
    {
        object ProcessMessage(string message);
    }
}
