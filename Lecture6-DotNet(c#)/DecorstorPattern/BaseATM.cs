using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BaseATM : IATM
    {
        public void InsertCard()
        {
            Console.WriteLine("Card inserted.");
        }

        public void EnterPin()
        {
            Console.WriteLine("PIN entered.");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Cash withdrawn.");
        }
    }
}
