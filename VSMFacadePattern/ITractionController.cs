using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    interface ITractionController
    {
        bool Enabled { get; set; }
        void Enable();
        void Disable();
    }
}
