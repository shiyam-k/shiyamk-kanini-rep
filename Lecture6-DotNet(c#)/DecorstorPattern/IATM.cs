using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IATM
    {
        void InsertCard();
        void EnterPin();
        void WithdrawCash();
    }
}
