using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGateSim.Components
{
    public class OrGate : ISimpleGate
    {
        public bool Activate(bool input1, bool input2)
        {
            return input1 || input2;
        }
    }
}
