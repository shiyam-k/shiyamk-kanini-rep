using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Training_29_03_202
    {
        public static string Greet(string name)
        {
            return "Hello " + name;
        }
        public int add(int a)
        {
            Console.WriteLine("One Parameter");

            return a + a;
        }
        public int add(int a, int b)
        {
            Console.WriteLine("Two Parameter");

            return a + b;
        }
        public double add(float a, float b, int c)
        {
            Console.WriteLine("Three Parameter(float)");

            return a + b + c;
        }

    }
    /* INHERITANCE */
   /* class Calculator_Base
    {
        public virtual int Operation(int a, int b)
        {
            return a+b;
        }
    }
    class Basic_Calculator : Calculator_Base
    {
       public override int Operation(int a, int b)
        {
            return a+b;
        }
    }
    class Sci_Calculator : Calculator_Base
    {
        public override int Operation(int a, int b)
        {
            return a - b;
        }
    }
    */
   class Account
    {
        int Account_No;
        string Account_Name;
        public Account(int Account_No, string Account_Name)
        {
            this.Account_No = Account_No;
            this.Account_Name = Account_Name;
        }
        public virtual void Display()
        {
            Console.WriteLine("Account Number: {0}", this.Account_No);
            Console.WriteLine("Account Number: {0}", this.Account_Name);

        }
    }
    class Savings_Account : Account
    {
        int amount;

        public Savings_Account(int acnt_no, string acnt_name, int amount) : base(acnt_no, acnt_name)
        {
            this.amount = amount;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Savings Balance {0}", this.amount);
        }
    }
    class Loan_Account : Account
    {
        int amount;

        public Loan_Account(int acnt_no, string acnt_name, int amount) : base(acnt_no, acnt_name)
        {
            this.amount = amount;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Loan Amount {0}", this.amount);
        }
    }

    class StaticConst
    {
        static int a = 1;
        static StaticConst()
        {
            inc();
        }
        public StaticConst()
        {
            inc();
        }
        static void inc()
        {
            a++;
        }
       public void Display()
        {
            Console.WriteLine("Register Number is: {0}", a);
        }
    }
    class Recursions
    {
        public int Fib(int n1,int n2, int n)
        {
            if(n == 0)
            {
                return 1;
                
            }
            Console.WriteLine(n1+n2);
            n -= 1;
            return Fib(n2, n1 + n2, n);
        }
        public void PrimeLim(int l1, int l2)
        {
            for (int i = l1; i <= l2; i++)
            {
                if (Prime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public bool Prime(int n)
        {
            bool b = true;
            for(int i = 2; i<=Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    b = false; 
                    break;
                }
                else
                {
                    b = true;
                }
            }
            return b;
        }

    }

    class Sample
    {
        static int VAL;
        public Sample()
        {
            VAL++;
        }
        public static void ObjectCount()
        {
            Console.WriteLine(VAL);
        }
    }
}
