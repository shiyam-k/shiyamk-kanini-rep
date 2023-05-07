using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingersbible_adodotnet_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SupporterClass s = new SupporterClass();
            if (s.GetStringInput("Click i to Install BingersBible", new List<string>() { "i"}).Equals("i")) { 
                BingersBible bb = new BingersBible();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
