using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Class1
    {
        int num1, num2;
        public void input()
        {

            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

        }
        public void add()
        {
            input();
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        public void subtract()
        {
            input();
            int num3 = num1 - num2;
            Console.WriteLine(num3);
        }
        public void multiply()
        {
            input();
            Console.WriteLine(num2 * num1);
        }
        public void divide()
        {
            input();
            Console.WriteLine(num1 / num2);
        }
    }
}