using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern
{
    interface ITransmissionController
    {
         int Gear { get; set; }
         int MaxGear { get; set; }
         void ShiftUp();
         void ShiftDown();
    }
}
