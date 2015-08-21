using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMFacadePattern.Controllers
{
    public interface ITachometerController
    {
         int Rpm { get; set; }
         int Limit { get; }
    }
}
