using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMFacadePattern.Controllers;
using System.Threading;

namespace VSMFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFacade vehicle = new VehicleFacade(new EngineController(), new TrachtionControlController(), new TransmissionController(), new TachometerController());
            vehicle.Start();
            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Accelerate();
            }

            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(100);
                vehicle.Brake();
            }
            vehicle.Off();

            Console.Read();
        }
    }
}
