using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class PinValidationDecorator : ATMDecorator
    {
        public PinValidationDecorator(IATM atm) : base(atm)
        {
        }

        public override void EnterPin()
        {
            Console.WriteLine("Validating PIN...");
            base.EnterPin();
        }
    }
}
