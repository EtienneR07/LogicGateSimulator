using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGateSim.Components
{
    public class XorGate : ISimpleGate
    {
        private NandGate _nand;
        private OrGate _or;
        private AndGate _and;

        public XorGate()
        {
            _nand = new();
            _or = new();
            _and = new();
        }

        public bool Activate(bool input1, bool input2)
        {
            throw new NotImplementedException();
        }
    }
}
