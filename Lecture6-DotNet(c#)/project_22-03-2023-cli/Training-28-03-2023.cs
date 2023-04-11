using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Training_28_03_2023
    {
        public void Amstrong(int l1, int l2)
        {
            int count = 0;
            for(int i = l1; i <= l2; i++)
            {
                int amstr = 0;
                for(int j = i; j > 0; j/= 10)
                {
                   amstr +=(int)Math.Pow(j % 10, i.ToString().Length);
                }
                if(amstr == i) {
                    count++;
                }
            }
            Console.WriteLine("Count of AMSTRONG NUMBERS: {0}",count);

        }
    }
    class Vowel_Const_Counter
    {
        int vowel_count;
        int const_count;
        public void MakeCount(string s)
        {
            foreach(char c in s)
            {
                if(c =='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' )
                {
                    vowel_count++;
                }
                else
                {
                    const_count++;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Vowel Count: {0}", vowel_count);
            Console.WriteLine("Consonant Count: {0}", const_count);

        }

        
    }
    class Bank
    {
        int amount;
        public Bank(int amount)
        {
            this.amount = amount;
        }

        public void Display()
        {
            Console.WriteLine("Available Balance :{0} ", amount);
        }
        public void Withdraw(int wAmount)
        {
            this.amount -= wAmount;
            Console.WriteLine("Transaction Complete");
        }
        public void Deposit(int dAmount)
        {
            this.amount += dAmount;
            Console.WriteLine("Transaction Complete");
        }
    }
}
