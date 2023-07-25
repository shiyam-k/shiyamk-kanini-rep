using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml;
using System.Security.Policy;
using System.Runtime.Remoting.Services;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.ComponentModel;
//using Calculator;
namespace project_22_03_2023_cli
{
    internal class Program
    {
        
        //person_2.get_bank_details();
        static bank_account[] bank_data = { new bank_account(46867666, "Person_1", "Savings", 45000, 5242,false),
            new bank_account(46867667, "Person_2", "Current", 5000, 5243,false),
            new bank_account(46867668, "Person_3", "Savings", 75000, 5252,false),
            new bank_account(46867669, "Person_4", "Current", 455000, 5142,false)};


        static MarkDB[] markData =
        {
            new MarkDB(101, 100, 96, 99),
            new MarkDB(102, 90, 96, 99),
            new MarkDB(103, 70, 96, 99),
            new MarkDB(104, 80, 96, 99),

        };
        static Student[] studentData =
        {
            new Student("101","Jeeva"),
            new Student("102","Chaitanya"),
            new Student("103","Santhosh"),
            new Student("104","Bhuvi"),

        };

        static List<HouseDet> persons= new List<HouseDet>();
        static List<EB> ebData= new List<EB>();
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


            // atm atm1 = new atm(bank_data[0]);

            /*C1 c = new C1();
            c.fun();*/
            /*int l = 5;
            int b = 5;
            int r = 5;
            Console.WriteLine("Area of Triangle {0}",(l*b)/2);
            Console.WriteLine("Area of Circle {0}", (2 * 3.14) * (r*r));
            float f = l;
            Console.WriteLine((float)f / 1);*/
            //Training_23_03_2023 tr = new Training_23_03_2023();
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
            tr.Program_10();
            int ?a = 5;
            int b = 5;
            int c = a ?? b;*/

            //ca.PrintArr(ca.GetArr());
            /* Class_Assignment ca = new Class_Assignment();
              int[] arr = ca.GetArr();
              Console.WriteLine("Array Sort:");
              ca.ArrSort(arr);*/
            /*Console.WriteLine("");
            Console.WriteLine("Array Reverse:");
            ca.RevArr(arr);
            Console.WriteLine("");

            Console.WriteLine("Array Remove Duplicates:");
            ca.RemDup(arr);
            Console.WriteLine("");

            Console.WriteLine("Array Sum:");

            Console.WriteLine(ca.ArrSum(arr, 0));
            Console.WriteLine("");

            Console.WriteLine("Number Palindrome:");

            ca.IsPal(ca.GetOneInput());
            Console.WriteLine("Array Print Odd:");

            ca.PrintOdd(arr);
            Console.WriteLine("");*/


            //ca.IsPal(ca.GetOneInput());

            //  ca.PrintOdd(ca.GetArr());

            // Training_27_03_2023 c = new Training_27_03_2023();
            // c.BuildJaggedArray();


            /*  Console.WriteLine("Welcome To St.Buddha School");
              Console.WriteLine("===========================");

              bool f = true;
              do
              {
                  Console.WriteLine("Search student data with Student ID or Student Name");
                  Console.WriteLine("Student Id Type id");
                  Console.WriteLine("Student Name type name");
                  String ac = Console.ReadLine().ToLower();
                  string id = null;
                  string name = null;
                  Student s = null;
                  MarkDB m = null;
                  bool b = false;
                  if (ac == "id")
                  {
                      Console.WriteLine("Enter Id");
                      id = Console.ReadLine().ToLower();
                      b = searchId(id);
                  }
                  else if (ac == "name")
                  {
                      Console.WriteLine("Enter Name");
                      name = Console.ReadLine().ToLower();
                      b = searchName( name);
                  }
                  else
                  {
                      Console.WriteLine("Enter Viable Student data");
                  }
                  if (b)
                  {
                      Console.WriteLine("Student Name: {0}", s.getName());
                      Console.WriteLine("Student ID: {0}", s.getId());
                      Console.WriteLine("English Mark: {0}", m.getEng());
                      Console.WriteLine("Maths Mark: {0}", m.getMath());
                      Console.WriteLine("Physics Mark: {0}", m.getPhy());
                      Console.WriteLine("Total: {0}", m.getTotal());


                  }
                  else
                  {
                      Console.WriteLine("No student data found");
                  }
                  bool searchId(string iid)
                  {
                      bool flag = false;
                      if (iid == "0" )
                      {
                          Console.WriteLine("Fail");
                          return flag;
                      }

                      for (int i = 0; i < 4; i++)
                      {
                          //Console.WriteLine(studentData[i].getId());
                          if (iid == studentData[i].getId().ToLower())
                          {
                              s = studentData[i];
                              m = markData[i];
                              flag = true;
                              break;
                          }
                      }
                      return flag;
                  }
                  bool searchName(string nname)
                  {
                      bool flag = false;
                      if (nname == null)
                      {
                          Console.WriteLine("Fail");
                          return flag;
                      }

                      for (int i = 0; i < 4; i++)
                      {
                         // Console.WriteLine(studentData[i].getName().ToLower() + " "+ nname);
                          if (nname == studentData[i].getName().ToLower())
                          {
                              s = studentData[i];
                              m = markData[i];
                              flag = true;
                              break;
                          }
                      }
                      return flag;
                  }
                  Console.WriteLine("Want to repeat Y/N");
                  string d = Console.ReadLine().ToLower();
                  if(d == "y")
                  {
                      f = true;
                  }
                  else
                  {
                      f = false;
                  }
              }
              while(f);
              */

            /*Employee emp = new Employee();
            emp.getDetails();
            emp.display();*/

            /*Calculator c = new Calculator();
            c.setData();
            Console.WriteLine(c.add());*/


            /* CurrencyConverter cc = new CurrencyConverter();
             bool b1 = true;
             do
             {
                 Console.WriteLine(cc.Converter());
                 Console.WriteLine("Want to contonue Y/N");
                 if(Console.ReadLine().ToLower() == "y")
                 {
                     b1 = true;
                 }
                 else
                 {
                     b1 = false;

                 }
             }
             while (b1);
            */







            /*Property p = new Property();
            p.Value(20);*/


            //Console.WriteLine(func());
            //Console.WriteLine("Theon, you are a \"GOOD\" man, Thank you...");

            /*  Student[] stuData = new Student[5];
              for(int i = 0; i<stuData.Length; i++)
              {
                  String[] stuObjData = new string[2];
                  Console.WriteLine("Enter Id");
                  stuObjData[0] = Console.ReadLine();
                  Console.WriteLine("Enter Name");
                  stuObjData[1] = Console.ReadLine();

                  stuData[i] = new Student(stuObjData[0], stuObjData[1]);
              }*/

            /* Class_Assignment ca = new Class_Assignment();
             int[] arr = new int[] { 1, 2, 1, 2, 1, 2 };
             ca.RemDup(arr);*/
            /*  
               Console.WriteLine("=====Bank=====");

               Bank b = new Bank(25000);
               bool bank = true;
               do
               {
                   Console.WriteLine("Enter D for Deposit");
                   Console.WriteLine("Enter W for Withdraw");
                   Console.WriteLine("Enter B for Balance");
                   string s = Console.ReadLine().ToLower();

                   switch (s)
                   {
                       case "d":
                           Console.WriteLine("Enter Amount to Deposit");
                           int dA = int.Parse(Console.ReadLine());
                           b.Deposit(dA);
                           break;
                       case "w":
                           Console.WriteLine("Enter Amount to Withdraw");

                           int wA = int.Parse(Console.ReadLine());
                           b.Withdraw(wA);
                           break;
                       case "b":
                           b.Display();
                           break;

                   }
                   bool bank_y_n = true;
                   while (bank_y_n)
                   {
                       Console.WriteLine("Enter Y/N");
                       string action = Console.ReadLine().ToLower();
                       if (action == "y")
                       {
                           bank = true;
                           bank_y_n = false;
                       }
                       else if (action == "n")
                       {
                           bank = false;
                           bank_y_n = false;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Enter between Y/N!!!");
                           bank_y_n = true;
                       }
                   }

               } while (bank);


               Console.WriteLine("");
               Console.WriteLine("=====Vowel Consonant Counter=====");

               Vowel_Const_Counter vcc = new Vowel_Const_Counter();
               bool b_vcc = true;
               do
               {
                   Console.WriteLine("Enter a String");
                   string s = Console.ReadLine().ToLower();
                   vcc.MakeCount(s);
                   vcc.Display();

                   bool y_n = true;
                   while (y_n)
                   {
                       Console.WriteLine("Enter Y/N");
                       string action = Console.ReadLine().ToLower();
                       if (action == "y")
                       {
                           b_vcc = true;
                           y_n = false;
                       }
                       else if (action == "n")
                       {
                           b_vcc = false;
                           y_n = false;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Enter between Y/N!!!");
                           y_n = true;
                       }
                   }
               }
               while (b_vcc);
               Console.WriteLine("");
               Console.WriteLine("=====Amstrong Number=====");
               Training_28_03_2023 t = new Training_28_03_2023();
               bool b_amstr = true;
               do
               {
                   Console.WriteLine("Enter Limit 1: ");
                   int l1 = Int32.Parse(Console.ReadLine());
                   Console.WriteLine("Enter Limit 1: ");
                   int l2 = Int32.Parse(Console.ReadLine());
                   t.Amstrong(l1, l2);
                   bool y_n = true;        
                   while (y_n)
                   {
                       Console.WriteLine("Enter Y/N");
                       string action = Console.ReadLine().ToLower();
                       if (action == "y")
                       {
                           b_amstr = true;
                           y_n = false;
                       }
                       else if (action == "n")
                       {
                           b_amstr = false;
                           y_n = false;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Enter between Y/N!!!");
                           y_n = true;
                       }
                   }
               }
               while (b_amstr);
            */
            /* Console.WriteLine("Enter Name");
             string s = Console.ReadLine();
             Console.WriteLine(Greet(s));*/
            /* Training_29_03_202 tr29= new Training_29_03_202();
              Console.WriteLine(tr29.add(100));
              Console.WriteLine(tr29.add(100, 110));
              Console.WriteLine(tr29.add(100.5f, 200.7f, 300));*/

            /*  Savings_Account sa = new Savings_Account(101, "person1", 20000);
              Loan_Account la = new Loan_Account(101, "person1", 40000);
              sa.Display();
              Console.WriteLine();
              la.Display();*/
            /*    StaticConst sc1 = new StaticConst();
                //StaticConst sc2 = new StaticConst();
                  sc1.Display();
                 // sc2.Display();
                 StaticConst sc2 = new StaticConst();
               sc2.Display();*/
            /*Recursions r = new Recursions();
            bool b_r = true;
            Sample S1 = new Sample();
            Sample S2 = new Sample();
            Sample S3 = new Sample();

            Sample.ObjectCount();*/
            /* do
             {
                 Console.WriteLine("Enter Limit");
                 int l = Int32.Parse(Console.ReadLine());

                 Console.WriteLine(0);
                 Console.WriteLine(1);
                 r.Fib(0, 1, l);
                 bool y_n = true;
                 while (y_n)
                 {
                     Console.WriteLine("Enter Y/N");
                     string action = Console.ReadLine().ToLower();
                     if (action == "y")
                     {
                         b_r = true;
                         y_n = false;
                     }
                     else if (action == "n")
                     {
                         b_r = false;
                         y_n = false;
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Enter between Y/N!!!");
                         y_n = true;
                     }
                 }
             }
             while (b_r);*/
            /*   do
               {
                   Console.WriteLine("Enter Limit 1");
                   int l1 = Int32.Parse(Console.ReadLine());

                   Console.WriteLine("Enter Limit 2");
                   int l2 = Int32.Parse(Console.ReadLine());
                   r.PrimeLim(l1,l2);
                   bool y_n = true;
                   while (y_n)
                   {
                       Console.WriteLine("Enter Y/N");
                       string action = Console.ReadLine().ToLower();
                       if (action == "y")
                       {
                           b_r = true;
                           y_n = false;
                       }
                       else if (action == "n")
                       {
                           b_r = false;
                           y_n = false;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Enter between Y/N!!!");
                           y_n = true;
                       }
                   }
               }
               while (b_r);*/
            /*Training_30_03_2023 tr30 = new Training_30_03_2023();
             Console.WriteLine("Enter Array Size");
             int n = Int32.Parse(Console.ReadLine());
             int[] arr = new int[n];
             arr = tr30.ArrValueGenerate(arr);
             tr30.PrintArr(arr);
             tr30.ArrSort(arr);
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(tr30.Abb(s));*/
            //CurrencySet s = new CurrencySet();
            //CurrencySet s1 = new CurrencySet("rupee");


            /*ArrayOP ar30 = new ArrayOP();

            CreateArr cr30 = null;
            bool b_a = true;
            do
            {
                Console.WriteLine("Enter Array size:");
                int n = Int32.Parse(Console.ReadLine());

                cr30 = new CreateArr(n);
                int[] arr = cr30.GetArr();
                Console.WriteLine();
                ar30.PrintArr(arr);
                Console.WriteLine();
                Console.WriteLine("Press k for deletion by Key/Index");
                Console.WriteLine("Press v for deletion by Value");
                Console.WriteLine();
                bool k_v = true;
                do
                {
                    string s = Console.ReadLine().ToLower();
                    if (s == "k")
                    {
                        Console.WriteLine("Enter Key or Index to delete: ");
                        int key = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        arr = ar30.ArrayDelByKey(arr, key);
                        ar30.PrintArr(arr);
                        k_v = false;
                    }
                    else if(s == "v")
                    {
                        Console.WriteLine("Enter Value to delete: ");
                        int val = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        arr = ar30.ArrDelByValue(arr, val);
                        ar30.PrintArr(arr);
                        Console.WriteLine();
                        k_v = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter between K/V");
                        Console.WriteLine();
                        k_v = true;
                    }
                }
                while (k_v);
                bool y_n = true;
                while (y_n)
                {
                    Console.WriteLine("Enter Y/N");
                    string action = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (action == "y")
                    {
                        b_a = true;
                        y_n = false;
                    }
                    else if (action == "n")
                    {
                        b_a = false;
                        y_n = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter between Y/N!!!");
                        Console.WriteLine();
                        y_n = true;
                    }
                }


            }
            while (b_a);*/
            /*  Training_04_03_2023 tr4 = new Training_04_03_2023();
               bool l = true;
               do
               {
                   Console.WriteLine("Enter Two numbers: ");
                   int a = Int32.Parse(Console.ReadLine());
                   int b = Int32.Parse(Console.ReadLine());

                   Console.WriteLine("GCD Using Recusion: {0}", tr4.GCD(a, b));
                   Console.WriteLine("GCD Using Loop: {0}", Training_04_03_2023.GCDLoop(a, b));
                   bool y_n = true;
                   while (y_n)
                   {
                       Console.WriteLine("Enter Y/N");
                       string action = Console.ReadLine().ToLower();
                       Console.WriteLine();
                       if (action == "y")
                       {
                           l = true;
                           y_n = false;
                       }
                       else if (action == "n")
                       {
                           l = false;
                           y_n = false;
                           break;
                       }
                       else
                       {
                           Console.WriteLine("Enter between Y/N!!!");
                           Console.WriteLine();
                           y_n = true;
                       }
                   }
               }
               while(l);   */
            /*  int[] a = new int[] { 1, 2, 3, 4, 5 };
              var aOdd = from t in a where t % 2 ==1 select t;
              foreach(int i in aOdd)
              {
                  Console.WriteLine(i);
              }
              string[] strArr = new[] { "Naruto", "Trash", "Sasuke" };
              var trashCan = from t in strArr where t == "Trash" select t;
              foreach (string i in trashCan)
              {
                  Console.WriteLine(i+" inside Trashcan");
              }*/
            List<Emp> EmpDB = new List<Emp>();
            /* EmpDB.Add(new Emp(101, "Santhosh", "TL"));
             EmpDB.Add(new Emp(102, "Jeeva", "Product Team"));
             EmpDB.Add(new Emp(103, "Bhuvi", "Data Engineer"));
             EmpDB.Add(new Emp(104, "Alvin", "Data Team"));
             bool rep = true;
             do
             {
                 Console.WriteLine("Enter role to get:");
                 string role = Console.ReadLine().ToLower();
                 var tl = from t in EmpDB where t.role.ToLower() == role select t;
                 foreach (Emp e in tl)
                 {
                     Console.WriteLine(e.name + " is a " + e.role);
                 }
                 bool y_n = true;
                 while (y_n)
                 {
                     Console.WriteLine("Enter Y/N");
                     string action = Console.ReadLine().ToLower();
                     Console.WriteLine();
                     if (action == "y")
                     {
                         rep = true;
                         y_n = false;
                     }
                     else if (action == "n")
                     {
                         rep = false;
                         y_n = false;
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Enter between Y/N!!!");
                         Console.WriteLine();
                         y_n = true;
                     }
                 }
             }
             while (rep);*/
            /* List <Car> CarDB = new List<Car>();
             CarDB.Add(new Car(101, "Benz", "sedan", 40000000));
             CarDB.Add(new Car(102, "BMW", "sedan", 80000000));
             CarDB.Add(new Car(103, "Rolls Royce", "sedan", 20000000));
             CarDB.Add(new Car(104, "Benz", "SUV", 10000000));

             bool rep = true;
             do
             {
                 Console.WriteLine("Press b to get cars by brand");
                 Console.WriteLine("Press m to get cars by model");
                 Console.WriteLine("Press p to get cars by price");

                 string s = Console.ReadLine();
                 dynamic car = new List<Car>() ;
                 switch (s)
                 {
                     case "b":
                         Console.WriteLine("Enter Brand Name: ");
                         String m = Console.ReadLine().ToLower();
                         car = from t in CarDB where t.brand.ToLower() == m select t;
                         break;
                     case "m":
                         Console.WriteLine("Enter Model Name: ");
                         String b = Console.ReadLine().ToLower();
                         car = from t in CarDB where t.model.ToLower() == b select t;
                         break;
                     case "p":
                         Console.WriteLine("Enter Budget");
                         int p = Int32.Parse(Console.ReadLine());
                         car = from t in CarDB where t.price <= p select t;
                         break;
                 }
                 foreach(Car cr in car)
                 {
                     Console.WriteLine(cr.id + " " + cr.brand + " " + cr.model + " " + cr.price);
                 }

                 bool y_n = true;
                 while (y_n)
                 {
                     Console.WriteLine("Enter Y/N");
                     string action = Console.ReadLine().ToLower();
                     Console.WriteLine();
                     if (action == "y")
                     {
                         rep = true;
                         y_n = false;
                     }
                     else if (action == "n")
                     {
                         rep = false;
                         y_n = false;
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Enter between Y/N!!!");
                         Console.WriteLine();
                         y_n = true;
                     }
                 }
             }
             while (rep);*/
            /*List<Car> list1 = new List<Car>();
            List<Car> list2 = new List<Car>();
            list1.Add(new Car(101, "Benz", "sedan", 40000000));
            list1.Add(new Car(102, "Benz", "sedan", 40000000));
            list2.Add(new Car(103, "Ben", "sedan", 40000000));
            list2.Add(new Car(104, "Ben", "sedan", 40000000));
            list1 = list1.Concat(list2).ToList();

            foreach (Car c in list1){
                Console.WriteLine(c.id);
            }
            */

            /* string XMLPath = "E:\\KANINI\\Lecture6-DotNet(c#)\\project_22-03-2023-cli\\XMLFile1.xml";
             XmlTextReader xr = new XmlTextReader(XMLPath);

             XmlDocument xd = new XmlDocument();
             xd.Load("E:\\KANINI\\Lecture6-DotNet(c#)\\project_22-03-2023-cli\\XMLFile1.xml");

             XmlNodeList books = xd.GetElementsByTagName("book");
             XmlNodeList titles = xd.GetElementsByTagName("title");
             //int ind = -1;

             Console.WriteLine("Enter Book Name: ");

             //print selected books
             string Utitle = Console.ReadLine().ToLower();
             int ind = -1;
             for (int i = 0; i<titles.Count; i++)
             {
                 if (titles[i].InnerText.ToLower() == Utitle) {
                     ind = i;
                 }
             }
                 int BookChildsCount = books[ind].ChildNodes.Count;
                 XmlNode ch = books[ind].FirstChild;
                 for (int j = 1; j <= BookChildsCount; j++)
                 {
                     Console.Write(ch.Name + ": ");
                     Console.WriteLine(ch.InnerText);
                     ch = ch.NextSibling;
                 }


             //Print all books
             foreach (XmlNode book in books)
             {



                  BookChildsCount = books.Item(++i).ChildNodes.Count ;
                  ch = book.FirstChild;
                 for (int j = 1; j<= BookChildsCount;j++)
                 {
                     Console.Write(ch.Name +": ");
                     Console.WriteLine(ch.InnerText);
                     ch = ch.NextSibling;
                 }
             }
             while (xr.Read())
             {


                 XmlNodeType nType = xr.NodeType;
                 if(xr.Name.ToString().ToLower() == "catalog")
                 {
                     continue;
                 }
                 switch(nType)
                 {
                     case XmlNodeType.Element:
                         Console.Write(xr.Name+": ");
                         break;
                     case XmlNodeType.Text:
                         Console.WriteLine(xr.Value);
                         break;
                     case XmlNodeType.Whitespace: 
                         break;
                 }
             }
            }*/
            /* PartialCalc pc = new PartialCalc();
             Console.WriteLine("Enter input1:");
             int a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter input2:");
             int b = Int32.Parse(Console.ReadLine());
             pc.PartialSub(a,b);
             pc.PartialAdd(a,b);
             pc.PartialProd(a, b);
             pc.PartialDiv(a, b);*/
            /*  Console.WriteLine("Enter a for ArrayList");
              Console.WriteLine("Enter l for ArrayList");
              Console.WriteLine("Enter h for ArrayList");
              Console.WriteLine("Enter s for ArrayList");
              Console.WriteLine("Enter q for ArrayList");
              Console.WriteLine("Enter d for ArrayList");

              char c = (char)Console.Read();


              ClassCollections cc = new ClassCollections(c);
              bool rep = true;
              do
              {
                  Console.WriteLine("Press A to Add");
                  Console.WriteLine("Press C to get count");
                  Console.WriteLine("Press cl to Clear");
                  Console.WriteLine("Press con to contains");
                  Console.WriteLine("Press r to remove");
                  Console.WriteLine("Press p to Print");
                  Console.WriteLine();
                  string oper = Console.ReadLine();
                  cc.Operation(oper);

                  bool y_n = true;
                  while (y_n)
                  {
                      Console.WriteLine("Enter Y/N");
                      string action = Console.ReadLine().ToLower();
                      Console.WriteLine();
                      if (action == "y")
                      {
                          rep = true;
                          y_n = false;
                      }
                      else if (action == "n")
                      {
                          rep = false;
                          y_n = false;
                          break;
                      }
                      else
                      {
                          Console.WriteLine("Enter between Y/N!!!");
                          Console.WriteLine();
                          y_n = true;
                      }
                  }
              }
              while (rep);*/
            /* List<Employee5> eml = new List<Employee5>();
               eml.Add(new Employee5(101, 1001, "Name1", "Role1"));
               eml.Add(new Employee5(101, 1002, "Name1", "Role1"));
               eml.Add(new Employee5(102, 1003, "Name1", "Role1"));
               eml.Add(new Employee5(101, 1004, "Name1", "Role1"));
               eml.Add(new Employee5(102, 1005, "Name1", "Role1"));
            */
            //var ee = from emp in eml group g by select eml;
            /* FileCreate num = new FileCreate("num.txt");
             FileCreate odd = new FileCreate("odd.txt");
             FileCreate even = new FileCreate("even.txt");
             FileCreate prime = new FileCreate("prime.txt");
             FileCreate noPrime = new FileCreate("noPrime.txt");


             FileOperations fo = new FileOperations();
             bool f = true;
             do
             {
                 Console.WriteLine("Press 'R' to read file");
                 Console.WriteLine("Press 'W' to write file");
                 Console.WriteLine("Press 'S' to Separate ");
                 Console.WriteLine("Press 'p' to Get Prime");
                 string s = Console.ReadLine().ToLower();

                 switch (s)
                 {
                     case "r":
                         fo.FileRead(num.GetFilePath()); break;
                         break;
                     case "w":
                         fo.FileWrite(num.GetFilePath());
                         break;
                     case "s":
                         fo.GetOddEven(num.GetFilePath(), odd.GetFilePath(), even.GetFilePath());
                         Console.WriteLine("press o to get odd");
                         Console.WriteLine("press e to get even");
                         string so = Console.ReadLine();

                         if (so.Equals("o"))
                         {
                             fo.FileRead(odd.GetFilePath()); break;  
                         }
                         else if (so.Equals("e"))
                         {
                             fo.FileRead(noPrime.GetFilePath());
                             break;
                         }
                         else
                         {
                             Console.WriteLine("input not recognized");
                             break;
                         }
                     case "p":
                         fo.GetPrimeNoPrime(num.GetFilePath(), prime.GetFilePath(), noPrime.GetFilePath());
                         Console.WriteLine("press p to get prime");
                         Console.WriteLine("press n to get no prime");
                         string sp = Console.ReadLine();

                         if (sp.Equals("p"))
                         {
                             fo.FileRead(prime.GetFilePath()); break;
                         }
                         else if(sp.Equals("n"))
                         {
                             fo.FileRead(noPrime.GetFilePath());
                             break;
                         }
                         else
                         {
                             Console.WriteLine("input not recognized");
                             break;
                         }
                 }


                 bool y_n = true;
                 while (y_n)
                 {
                     Console.WriteLine("Enter Y/N");
                     string action = Console.ReadLine().ToLower();
                     Console.WriteLine();
                     if (action == "y")
                     {
                         f = true;
                         y_n = false;
                     }
                     else if (action == "n")
                     {
                         f = false;
                         y_n = false;
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Enter between Y/N!!!");
                         Console.WriteLine();
                         y_n = true;
                     }
                 }
             }
             while (f);*/

            /* FileCreate wordCount = new FileCreate("wordcount");
             FileWordCount fwc = new FileWordCount();
             bool wc = true;
             do
             {
                 Console.WriteLine("");
                 Console.WriteLine("Press w to Write into file");
                 Console.WriteLine("Press r to read file");
                 Console.WriteLine("Press C to Count Word");
                 string s = Console.ReadLine().ToLower();
                 switch (s)
                 {
                     case "w":
                         fwc.FileWrite(wordCount.GetFilePath());
                         break;
                     case "r":
                         fwc.FileRead(wordCount.GetFilePath());
                         break;
                     case "c":
                         Console.WriteLine("");
                         Console.WriteLine("Enter Word to search");
                         string word = Console.ReadLine().ToLower();
                         fwc.WordCount(wordCount.GetFilePath(), word);
                         break;
                 }
                 bool y_n = true;
                 while (y_n)
                 {
                     Console.WriteLine("");
                     Console.WriteLine("Enter Y/N");
                     string action = Console.ReadLine().ToLower();
                     Console.WriteLine();
                     if (action == "y")
                     {
                         wc = true;
                         y_n = false;
                     }
                     else if (action == "n")
                     {
                         wc = false;
                         y_n = false;
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Enter between Y/N!!!");
                         Console.WriteLine();
                         y_n = true;
                     }
                 }
             }
             while (wc);*/
            /* Console.WriteLine("Enter Triangle size");
             int n = Int32.Parse(Console.ReadLine());
             int c = 0 ;
             for(int i = 0; i<=n; i++)
             {
                 for(int j = 0; j<i; j++)
                 {
                     Console.Write((++c).ToString() +" ");
                 }Console.WriteLine();
             }*/
            //atm a = new atm(bank_data[0]);
            /*int a =0;
            Console.WriteLine(f(ref a));*/


            /* List<Employee5> employee5s= new List<Employee5>();
             employee5s.Add(new Employee5(101, 1001, "Name", "role"));
             employee5s.Add(new Employee5(101, 1002, "Name", "role"));

             employee5s.Add(new Employee5(101, 1003, "Name", "role"));
             employee5s.Add(new Employee5(102, 1004, "Name", "role"));
             employee5s.Add(new Employee5(102, 1005, "Name", "role"));
             employee5s.Add(new Employee5(101, 1006, "Name", "role"));

             var a = 10;
             dynamic d = from e in employee5s
                         group e by e.depId into g
                         select new { id = g.Key, Count = g.Count() };
             dynamic sum = from e in employee5s
                           group e by e.depId into g
                           select new { deptId = g.Key, s = g.Sum(i => i.id) };
             foreach (var i in sum)
             {
                 Console.WriteLine(i);
             }*/


            /*Test_06_04_2023 test = new Test_06_04_2023();
             Console.WriteLine("Enter a Number");
             int n = Int32.Parse(Console.ReadLine());
             test.Pattern(n);


             ebData.Add(new EB(101, "Person1"));
             ebData.Add(new EB(102, "Person2"));
             ebData.Add(new EB(103, "Person3"));
             ebData.Add(new EB(104, "Person4"));
             persons.Add(new HouseDet("Person1", true,true, true, true,true));
             persons.Add(new HouseDet("Person2", true, false, true, true, true));
             persons.Add(new HouseDet("Person3", false, false, false, false, false));
             persons.Add(new HouseDet("Person4", true, true, false, true, false));


            bool e_b = true;
            do
            {
                Console.WriteLine("Enter EB id");
                int id = Int32.Parse(Console.ReadLine());

                bool da = false;
                EB ebPerson = null;
                foreach(EB eb in ebData)
                {
                    if(id == eb.ebId)
                    {
                      ebPerson = eb;
                        da = true;
                        break;
                    }
                    else
                    {
                        da = false;

                    }
                }

              if (da)
              {
                  ebPerson.GetEBHouse();
                  Console.WriteLine("Hi {0}", ebPerson.name);
                  Console.WriteLine("Welcome to Electricity Board");
                  Console.WriteLine("Press 0 to generate Reading");
                  Console.WriteLine("Press 1 to  Calculate Bill");
                  bool e_y_n = true; ;
                  do
                  {
                      int act = Int32.Parse(Console.ReadLine());
                      if (act == 0)
                      {
                          Console.WriteLine("{0} Number of units consumed is {1}", ebPerson.name, ebPerson.EnterReading());
                      }
                      else if (act == 1)
                      {
                          Console.WriteLine("{0} your Electricity Bill is {1}", ebPerson.name, ebPerson.CalculateBill());

                      }
                      else
                      {
                          e_y_n = false;
                      }
                  }
                  while (e_y_n);
              }
              else
              {
                  Console.WriteLine("No User Data Found!");
              }
              bool y_n = true;
              while (y_n)
              {
                  Console.WriteLine("");
                  Console.WriteLine("Enter Y/N");
                  string action = Console.ReadLine().ToLower();
                  Console.WriteLine();
                  if (action == "y")
                  {
                      e_b = true;
                      y_n = false;
                  }
                  else if (action == "n")
                  {
                      e_b = false;
                      y_n = false;
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Enter between Y/N!!!");
                      Console.WriteLine();
                      y_n = true;
                  }
              }


          }
          while (e_b);

             List<Players> pList = new List<Players>();
             pList.Add(new Players(101, "Playe1", 1001, "chennai"));
             pList.Add(new Players(102, "Playe2", 1002, "chennai"));
             pList.Add(new Players(103, "Playe3", 1003, "chennai"));
             pList.Add(new Players(104, "Playe4", 1001, "delhi"));
             pList.Add(new Players(105, "Playe5", 1002, "mumbai"));
             pList.Add(new Players(106, "Playe6", 1002, "mumbai"));


             var count = from p in pList
                         group p by p.Player_City into p_group
                         select new { city = p_group.Key, count = p_group.Count() };
             foreach(var v in count)
             {
                 Console.WriteLine(v);   
             }

            Calc c = new Calc();
             Console.WriteLine("Enter A");
             int a = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter B");
             int b = Int32.Parse(Console.ReadLine());
             c.Display();
             Console.WriteLine("Addition of a & b "+ c.Add(a, b));
             Console.WriteLine("Subtraction of a & b " + c.Sub(a, b));
             Console.WriteLine("Multiplication of a & b " + c.Mul(a, b));
             Console.WriteLine("Division of a & b " + c.Div(a, b));


           IdGen ig1 = new IdGen();
           IdGen ig2 = new IdGen();
           IdGen ig3 = new IdGen();
*/

            /* test_10_04_2023 t10 = new test_10_04_2023();
            t10.Amstrong(Int32.Parse(Console.ReadLine()));
             Console.WriteLine("Enter a number");
             t10.Pattern(Int32.Parse(Console.ReadLine()));
             Console.WriteLine();    
             TemperatureCoversion tc = new TemperatureCoversion();*/

            //FileHandling fh = new FileHandling();

            /*
              Console.WriteLine("Voters Eligibility");
              Console.WriteLine("Enter age");
             VoterEligibility ve = new VoterEligibility(Int32.Parse(Console.ReadLine()));*/

            //AdvancedMath am = new AdvancedMath();

            /*displayA arr1 = new displayA();
            displayB arr2 = new displayB();
            arr1.x = 0;
            arr2.x = 0;
            arr1.cal(2);
            arr2.cal(2);
            Console.WriteLine(arr1.x + " " + arr2.x);
            Console.ReadLine();*/
            Training_04_03_2023 tr = new Training_04_03_2023();
            Console.WriteLine(tr.GCD(100, 200));




        }

        
        public static HouseDet GetHouseDetails(string name)
        {
            HouseDet per = null;
            foreach (HouseDet person in persons)
            {
                if(person.name.Equals(name))
                {
                    per = person;
                }
                
            }
            return per;
        }
        

        public static bank_account get_account_name(int accnt_no)
        {
            int b = 0;
            for (int i = 0; i < bank_data.Length; i++)
            {
                if (accnt_no == bank_data[i].get_account_number())
                {
                    b = i;
                    break;
                }
            }

            return bank_data[b];
        }
    }
    interface calc
    {
        void cal(int i);
    }
    class displayA : calc
    {
        public int x;
        public void cal(int i)
        {
            x = i * i;
        }
    }
    class displayB : calc
    {
        public int x;
        public void cal(int i)
        {
            x = i / i;
        }
    }

}
    
