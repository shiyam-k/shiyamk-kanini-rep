using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CardScannerDecorator : ATMDecorator
    {
        public CardScannerDecorator(IATM atm) : base(atm)
        {
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card scanned. " + "Scanning card validity...");
            base.InsertCard();
        }
    }
}
