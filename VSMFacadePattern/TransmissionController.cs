using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    class TransmissionController:ITransmissionController
    {

        public int Gear
        {
            get;
            set;
        }

        public int MaxGear
        {
            get;
            set;
        }

        public void ShiftUp()
        {
            if (Gear<MaxGear)
            {
                Gear++;
                Console.WriteLine(string.Format("Shift Down to Gear {0} ",Gear));
            }
        }

        public void ShiftDown()
        {
            if (Gear>0)
            {
                Gear--;
                Console.WriteLine(string.Format("Shift Up to Gear {0}",Gear));
            }
        }
    }
}
