using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGateSim.Components
{
    interface ISimpleGate
    {
        bool Activate(bool input1, bool input2);
    }
}
