using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class NegitiveNumberException:ApplicationException
    {
        public override string Message => "You have entered a Negitive Number.";
    }
}
