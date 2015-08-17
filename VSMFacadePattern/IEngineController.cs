using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
     interface IEngineController
    {
         bool Running { get; }
         void Start();
         void Stop();
    }
}
