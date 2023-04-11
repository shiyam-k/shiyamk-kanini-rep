using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class bank_account
    {
         int account_number;
         string account_holder_name;
         string account_type;
         int account_balance;
         int atm_pin;
        bool cardless_transfer = false;
        
       
        public bank_account(int a_n,String a_name, String a_type, int a_balance, int atm_pin, bool c_t)
        {
            this.account_number = a_n;
            this.account_holder_name = a_name;
            this.account_type = a_type;
            this.account_balance = a_balance;
            this.atm_pin = atm_pin;
            this.cardless_transfer = c_t;
        }
        public int get_account_number()
        {
            return this.account_number;
        }
        public String get_account_name()
        {
            return this.account_holder_name;
        }
        public string get_account_type()
        {
            return this.account_type;
        }
        private void set_account_balance(int new_bal)
        {
            this.account_balance = new_bal;
        }
        public int get_account_balance()
        {
            return this.account_balance;
        }
        public bool get_cardless_transfer()
        {
            return this.cardless_transfer;
        }
        public void set_avail_cardless_transfer(bank_account person, bool s, int a_n)
        {
            if(a_n == person.account_number)
            {
                String act;
                Console.WriteLine("Continue Y/N");
                act = Console.ReadLine().ToLower();
                if (act == "y" & cardless_transfer == true)
                {
                    person.cardless_transfer = s;
                    Console.WriteLine("Cardless Transaction Availed");
                }
                else if (act == "n")
                {
                    Console.WriteLine("Transaction Failed");
                }
                else
                {
                    Console.WriteLine("Cardless Transfer already available");
                }
                

            }
             

        }
        public void get_bank_details()
        {
            Console.WriteLine("======================");
            Console.WriteLine("MARIYAMMA INDIAN BANK");
            Console.WriteLine("======================");
            Console.WriteLine($"Account Holder Name: {get_account_name()}");
            Console.WriteLine($"Account Number: {get_account_number()}");
            Console.WriteLine($"Account Type: {get_account_type()}");
            Console.WriteLine($"Account Balance: {get_account_balance()}");



        }
        private int get_atm_pin()
        {
            return this.atm_pin;
        }
        public bool Withdraw(bank_account person, int amt, int pin)
        {
            bool p = false;
            if(pin == person.get_atm_pin())
            {
                int new_bal = person.get_account_balance() - amt;
                person.set_account_balance((int)new_bal);
                p = true;
            }
            return p;

        }
        public bool Deposit(bank_account person, int amt, int pin)
        {
            bool p = false;
            if (pin == person.get_atm_pin())
            {
                int new_bal = person.get_account_balance() + amt;
                person.set_account_balance((int)new_bal);
                p = true;
            }
            return p;
        }
        public void ct_transfer(bank_account p1, bank_account p2, int amt)
        {
            int t1 = p1.get_account_balance() - amt;
            int t2 = p2.get_account_balance() + amt;
            p1.set_account_balance(t1);
            p2.set_account_balance(t2);
        }
        static void main(String[] args)
        {
            /*bank_account person_1 = new bank_account(46867666, "Person_1", "Savings", 45000, 5242);
            bank_account person_2 = new bank_account(46867667, "Person_2", "Savings", 5000, 5243);
            bank_account person_3 = new bank_account(46867668, "Person_3", "Savings", 75000, 5252);
            bank_account person_4 = new bank_account(46867669, "Person_4", "Savings", 455000, 5142);
            person_1.get_bank_details();*/

        }
    }
}
