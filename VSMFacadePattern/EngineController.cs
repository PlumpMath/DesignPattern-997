using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    class EngineController:IEngineController
    {
        public bool Running { get; private set; }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine Started");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("Engine Stoped");
        }
    }
}
