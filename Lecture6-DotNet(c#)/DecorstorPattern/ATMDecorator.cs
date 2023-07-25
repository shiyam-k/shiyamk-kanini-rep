using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ATMDecorator : IATM
    {
        protected IATM atm;

        public ATMDecorator(IATM atm)
        {
            this.atm = atm;
        }

        public virtual void InsertCard()
        {
            atm.InsertCard();
        }

        public virtual void EnterPin()
        {
            atm.EnterPin();
        }

        public virtual void WithdrawCash()
        {
            atm.WithdrawCash();
        }
    }
}
