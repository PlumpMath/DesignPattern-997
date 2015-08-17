using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    class TrachtionControlController:ITractionController    
    {

        public bool Enabled
        {
            get;
            set;
        }

        public void Enable()
        {
            Enabled = true;
            Console.WriteLine("Traction controled enabled");
        }

        public void Disable()
        {
            Enabled = false;
            Console.WriteLine("Traction controled disabled");
        }
    }
}
