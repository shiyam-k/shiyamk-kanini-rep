using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Training_23_03_2023
    {
        int GetOneInput()
        {
            Console.WriteLine("Enter input");
            int n = Int32.Parse(Console.ReadLine());
            return n;
        }
       
        /* Question 1*/
        public void Program_1(){
            int n = GetOneInput();
            for(int i =0; i<n; i++)
            {
                for(int j = 0; j<i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /* Question 2*/
        public void Program_2()
        {
            int n = GetOneInput();
            for (int x = 1; x <= n; x++)
            {
                for (int y = x; y < n; y++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /* Question 3*/
        public void Program_3(){
            int n = GetOneInput();
            int count = n-1;
            for (int i =0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(j >= count)
                    {
                        Console.Write("*") ;
                        count--;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        /* Factorial for a given number*/
        public void Program_4()
        {
            int n = GetOneInput(); int res = 1;
            while(n > 0)
            {
                res *= n; n--;
            }
            Console.WriteLine(res);
        }
        /* Question 5 */
        public void Program_5()
        {
            int n = GetOneInput();
            int t = n;
            int res = 0;
            while(t > 0)
            {
                res +=(int) Math.Pow((t % 10),3);
                t /= 10;
            }
            if(res == n)
            {
                Console.WriteLine("{0} is Amstrong Number", res);
            }
            else
            {
                Console.WriteLine("{0} is not Amstrong Number", res);

            }
        }

        /* Question 6 */
        /*public void pass()
        {
            int n = GetOneInput();
            for(int i = 1; i<=n; i++)
            {
                Program_6(i);
            }
        }*/
        public void Program_6(/*int n*/)
        {
           //Console.WriteLine(6 % 3);
            int n = GetOneInput();
            int res = 0;
            for(int i = 1; i<= n/2; i++)
            {
                if(n % i == 0)
                {
                    //Console.WriteLine(i);
                    res += i;
                }
            }
            //Console.WriteLine(res);
            if(res == n)
            {
                Console.WriteLine("{0} Perfect {1}",n, res);
            }
            else
            {
                Console.WriteLine("{0} ImPerfect {1}", n, res);
            }
        }

        /* Temperature Conversion */
        public void Program_7()
        {
            int n = GetOneInput();
            Console.WriteLine("Click 1 for C to F");
            Console.WriteLine("Click 2 for F to C");
            int a = GetOneInput();
            float res = 0;
            if(a == 1)
            {
                res = (n * 1.8f) + 32;
            }
            else if(a == 2)
            {
                res = (n - 32 ) * (float)(5/9);
            }
            else
            {
                Console.WriteLine("Enter a choose a valid option");
            }
            Console.WriteLine(res);
        }
        public void Program_8()
        {
            int p = GetOneInput();
            int n = GetOneInput();
            int r = GetOneInput();
            Console.WriteLine("Simple Interest{0}", (p * n * r) / 100);
        }
        

            

            /* Calculate compound interest */
            
        public void Program_9()
        {
            double p = Convert.ToDouble(GetOneInput());
            double r = Convert.ToDouble(GetOneInput());

            Console.Write(r);
            double m = Convert.ToDouble(GetOneInput());

            Console.Write(m);
            int compound = (int)(p * Math.Pow(1 + (r / 100*m),m));

            Console.WriteLine("Compound Interest is " + compound);
            
        }
        public void Program_10()
        {
            int a = GetOneInput();
            int b = GetOneInput();
            int c = GetOneInput();
            double r1 = (b * -1) + (Math.Sqrt(((b * b) - 4 * a * c)));
            r1 = r1 / 2 * a;
            double r2 = (b * -1) - (Math.Sqrt(((b * b) - 4 * a * c)));
            r2 = r2 / 2 * a;
            Console.WriteLine("Quadratic {0} {1}", r1, r2);
        }
        
        
        static void main(string[] args)
        {
            //Console.WriteLine(func());
        }
    }
}
