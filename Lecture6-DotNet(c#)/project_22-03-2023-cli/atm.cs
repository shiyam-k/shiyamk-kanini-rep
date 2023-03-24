using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class atm
    {
        Program p = new Program();
        public atm(bank_account person)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Welcome to Mariyamma Indian Bank ATM");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            bool flag = true;
                 
            flag = true;
            do
            {
                Console.WriteLine("Insert ATM card");
                Console.WriteLine("Type INSERT for Insertion");
                Console.WriteLine("Type CT for cardless transfer");
                String card = (Console.ReadLine()).ToLower();
                Console.WriteLine("");
                //Console.WriteLine(person.get_cardless_transfer() == true );
                if (person.get_cardless_transfer() & card == "ct")
                {
                    Console.WriteLine("Enter your passbook number: ");
                    int p1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Recipient's passbook number: ");
                    int p2 = Int32.Parse(Console.ReadLine());
                    bank_account p2_data = p.get_account_name(p2);
                    if (p2_data.get_account_number() == p2)
                    {
                        Console.WriteLine("Enter Amount to deposit");
                        int amt = Int32.Parse(Console.ReadLine());
                        person.ct_transfer(person, p2_data, amt);
                        Console.WriteLine("Available Balancce :{0} ", person.get_account_balance());
                    }
                    else
                    {
                        Console.WriteLine("No Bank Data found on {0} kindly Recheck it ", p2);
                    }
                }
                
                else if (card == "insert")
                {
                    Console.WriteLine("Type `W` for Withdraw Amount");
                    Console.WriteLine("Type  `B` for Inquire Balance");
                    Console.WriteLine("Type `D` for Deposit Amount");
                    Console.WriteLine("Type `A` to Avail Cardless Transfer");
                    Console.WriteLine("");
                    String op = Console.ReadLine().ToLower();
                    switch (op)
                    {
                        case "w":
                            Console.WriteLine("");

                            Console.WriteLine("Enter Amount to Withdraw: ");
                            int amt = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Enter Pin : ");
                            int w_pin = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Re-enter Pin : ");
                            int w_pin_1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (w_pin != w_pin_1)
                            {
                                Console.WriteLine("Pins are not matching");
                                Console.WriteLine("");

                                break;
                            }
                            if (amt > person.get_account_balance())
                            {
                                Console.WriteLine("Withdrawal amount should not be greater than Account Balance");
                                Console.WriteLine("");
                                break;
                            }
                            else
                            {
                                bool progress = person.Withdraw(person, amt, w_pin);
                                if (progress)
                                {
                                    Console.WriteLine("Transaction Complete");
                                    Console.WriteLine("Available Balancce :{0} ", person.get_account_balance());
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("PIN is wrong");
                                    Console.WriteLine("");
                                }
                            }
                            break;
                        case "b":
                            Console.WriteLine("Transaction Complete");
                            Console.WriteLine("Available Balancce :{0} ", person.get_account_balance());
                            Console.WriteLine("");
                            break;
                        case "d":
                            Console.WriteLine("Enter Amout to Deposit");
                            int d_amt = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Enter Pin : ");
                            int d_pin = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Re-enter Pin : ");
                            int d_pin_1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (d_pin != d_pin_1)
                            {
                                Console.WriteLine("Pins are not matching");
                                Console.WriteLine("");
                                break;
                            }
                            bool p = person.Deposit(person, d_amt, d_pin);
                            if (p)
                            {
                                Console.WriteLine("Transaction Complete");
                                Console.WriteLine("Available Balancce :{0} ", person.get_account_balance());
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Transaction Failed");
                                Console.WriteLine("");
                            }
                            break;
                        case "a":
                            Console.WriteLine("Enter Account Number: ");
                            int accnt_no = Int32.Parse(Console.ReadLine());
                            person.set_avail_cardless_transfer(person, true, accnt_no);
                            break;
                    }
                }
                else if(person.get_cardless_transfer() == false & card == "ct")
                {
                    Console.WriteLine("Cardless Transfer Not availed");
                }
                
                
                String act;
                Console.WriteLine("Want to continue ");
                Console.WriteLine("Type Y/N");
                act = Console.ReadLine().ToLower();
                Console.WriteLine("");
                if (act == "y")
                {
                    flag = true;
                }
                else if (act == "n")
                {
                    flag = false;
                }
            }
            while(flag);

        }

        void main(String[] args)
        {

        }

        
    }
}
