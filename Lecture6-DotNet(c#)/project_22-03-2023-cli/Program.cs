using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
//using Calculator;
namespace project_22_03_2023_cli
{
    internal class Program
    {
        
        //person_2.get_bank_details();
        public static bank_account[] bank_data = { new bank_account(46867666, "Person_1", "Savings", 45000, 5242,false),
            new bank_account(46867667, "Person_2", "Current", 5000, 5243,false),
            new bank_account(46867668, "Person_3", "Savings", 75000, 5252,false),
            new bank_account(46867669, "Person_4", "Current", 455000, 5142,false)};
        static void Main(string[] args)
        {
            /*bool con = true;
            while (con)
            {
                

                Console.Title = "Hello World";
                String s = "Shiyam";
                Console.WriteLine($"My name is ,{s}");
                // Redirect standard input from the console to the input file.
                var reader = new StreamReader(args[0]);
                Console.SetIn(reader);
                String getName;
                while((getName = Console.ReadLine()) != null)
                {
                    string newLine = getName.Replace(("").PadRight(5, ' '), "\t");
                    Console.WriteLine(newLine);
                }

                Console.WriteLine(getName);
                //String newN = Console.ReadLine();
                int[] newArr =
                    new int[2];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = Int32.Parse(Console.ReadLine());
                }
                //Console.WriteLine($"array of two ,{newArr[0] + newArr[1]}");
                int res = 0;
                for (int i = 0; i < newArr.Length; i++)
                {
                    res += newArr[i];
                }
                Console.WriteLine($"array sum ,{res}");
                con = false;
            }*/
            //Console.Read();

            /*

            Console.Title = "Hello World";
            String s = "Shiyam";
            Console.WriteLine("My name is {0}", s);
            Console.WriteLine($"My name is ,{s}");
            int[] newArr = new int[2];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = Int32.Parse(Console.ReadLine());
            }
            int res = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                res += newArr[i];
            }

            */

            //Console.WriteLine($"array sum ,{res}");
            /* Console.WriteLine("====================");
             Console.WriteLine("Simple Calculator");
             Console.WriteLine("====================");

             Console.WriteLine("");

             bool con = false;
             do
             {
                 Console.WriteLine("Click + for addition");
                 Console.WriteLine("Click - for subtraction");
                 Console.WriteLine("Click / for Multiplication");
                 Console.WriteLine("Click * for division");
                 Console.WriteLine("Click % for Modulus");
                 Console.WriteLine("");
                 Console.WriteLine("Enter Operation:");
                 string op = Console.ReadLine();
                 Console.WriteLine("");

                 Console.WriteLine("Enter Number One:");

                 int a = Int32.Parse(Console.ReadLine());
                 Console.WriteLine("");

                 Console.WriteLine("Enter Number Two:");
                 int b = Int32.Parse(Console.ReadLine());
                 /*Console.WriteLine("Addition of two numbers: "+ (a+b).ToString());
                 Console.WriteLine($"Addition of two numbers: {a + b}");
                 Console.WriteLine("Addition of two numbers:{0}", a + b);

                 switch (op)
                 {
                     case "+":
                         Console.WriteLine("Sum of Two:");
                         Console.WriteLine(a + b);
                         break;
                     case "-":
                         Console.WriteLine("Difference of Two:");

                         Console.WriteLine(a - b);
                         break;
                     case "*":
                         Console.WriteLine("Product of Two:");

                         Console.WriteLine(a * b);
                         break;
                     case "/":
                         Console.WriteLine("Divison of Two:");

                         Console.WriteLine(a/b);
                         break;
                     case "%":
                         Console.WriteLine("Modulus of Two:");

                         Console.WriteLine(a % b);
                         break;
                     default:
                         Console.WriteLine("Incorrect Output");
                         break;
                 }
                 Console.WriteLine("");

                 Console.WriteLine("Do you want to continue Y/N");
                 String act = Console.ReadLine();
                 Console.WriteLine("");

                 if (act == "Y" || act == "y")
                 {
                     con = true;
                 }
                 else if(act == "N" || act == "n")
                 {
                     //con = false;
                     Console.WriteLine("Are you sure Y/N");
                     String act2 = Console.ReadLine();
                     Console.WriteLine("");
                     if (act2 == "Y" || act2 == "y")
                     {
                         Console.WriteLine("Have a Nice Day ");
                         con = false;
                     }
                     else if (act2 == "N" || act2 == "n")
                     {
                         con = true;
                     }
                     else
                     {
                         Console.WriteLine("Incorrect input try Y/N");
                     }
                 }
                 else
                 {
                     Console.WriteLine("Incorrect input try Y/N");
                 }
             }
             while(con);
            */
            /*  string willing = "";
              Calculator c = new Calculator();
              do
              {
                  Console.WriteLine("========================");
                  Console.WriteLine("Welcome to My Calculator");
                  Console.WriteLine("========================");
                  Console.WriteLine("Select the Operations among the following");
                  Console.WriteLine("1.Add");
                  Console.WriteLine("2.Subtract");
                  Console.WriteLine("3.Multiply");
                  Console.WriteLine("4. Division");
                  int choice = Int32.Parse(Console.ReadLine());
                  switch (choice)
                  {
                      case 1:
                          c.add();
                          break;
                      case 2:
                          c.subtract();
                          break;
                      case 3:
                          c.multiply();
                          break;
                      case 4:
                          c.divide();
                          break;
                  }
                  Console.WriteLine("Do you wanna continue?(y or n)");
                  willing = Console.ReadLine();
                  if (willing.Equals("n"))
                  {
                      Console.WriteLine("Thank you!!! Visit again");
                      break;
                  }
              } while (willing.Equals("yes"));
              Console.Read();*/
            /*Console.WriteLine("Enter a number");
            int n = Int32.Parse(Console.ReadLine());
            int[] newArr =
                      new int[n];
            Console.WriteLine($"Enter Array Elements of size {n}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in reverse order");
            for (int i = newArr.Length - 1; i > -1; i--)
            {
                Console.WriteLine(newArr[i]);
            }*/


            //atm atm1 = new atm(bank_data[0]);

            /*C1 c = new C1();
            c.fun();*/
            /*int l = 5;
            int b = 5;
            int r = 5;
            Console.WriteLine("Area of Triangle {0}",(l*b)/2);
            Console.WriteLine("Area of Circle {0}", (2 * 3.14) * (r*r));
            float f = l;
            Console.WriteLine((float)f / 1);*/
            Training_23_03_2023 tr = new Training_23_03_2023();
            //tr.Program_1();
            /*Console.WriteLine("Pattern 1 " );
            tr.Program_1();
            Console.WriteLine("Pattern 2 ");
            tr.Program_2();
            Console.WriteLine("Pattern 3 ");
            tr.Program_3();
            Console.WriteLine("Factorial");
            tr.Program_4();
            Console.WriteLine("Amstrong");
            tr.Program_5();
            Console.WriteLine("Perfect");
            tr.Program_6();
            Console.WriteLine("Temperature Conversion");
            tr.Program_7();
            Console.WriteLine("Simple Interest");
            tr.Program_8();
            Console.WriteLine("Compound Interest");
            tr.Program_9();
            Console.WriteLine("Quadratic ");
            tr.Program_10();*/
            int ?a = 5;
            int b = 5;
            int c = a ?? b;

            //Console.WriteLine(func());
            Console.WriteLine("Theon, you are a \"GOOD\" man, Thank you...");
        }
        public static int func()
        {
            int? a = null;
            return (int)a;
        }
        public bank_account get_account_name(int accnt_no)
        {
            int b = 0;
            for(int i = 0; i<bank_data.Length; i++)
            {
                if(accnt_no == bank_data[i].get_account_number())
                {
                    b = i;
                    break;
                }
            }

            return bank_data[b];
        }
    }
}

