using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGateSim.Components
{
    public class Adder
    {
        private bool _input1;
        private bool _input2;
        private bool _carry;
        private Adder? _next;

        public Adder(bool input1, bool input2, Adder? next)
        {
            _input1 = input1;
            _input2 = input2;
            _next = next;
        }

        public void SetCarry(bool carry)
        {
            _carry = carry;
        }

        public bool Activate()
        {
            var halfAdder1 = HalfAdder(_input1, _input2);
            var halfAdder2 = HalfAdder(_carry, halfAdder1.Output1);
            var carry = Or(halfAdder1.Output2, halfAdder2.Output2);
            var result = halfAdder2.Output1;

            if (_next == null)
            {
                if (carry) throw new OverflowException();
                return result;
            }

            _next.SetCarry(carry);
            _next.Activate();

            return result;
        }

        public bool Or(bool input1, bool input2)
        {
            return input1 || input2;
        }

        public bool And(bool input1, bool input2)
        {
            return input1 && input2;
        }

        public bool Nand(bool input1, bool input2)
        {
            return !(input1 && input2);
        }

        public bool Xor(bool input1, bool input2)
        {
            return And(Or(input1, input2), Nand(input1, input2));
        }

        public (bool Output1, bool Output2) HalfAdder(bool input1, bool input2)
        {
            return (Xor(input1, input2), And(input1, input2));
        }
    }
}
