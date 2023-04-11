using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Training_04_03_2023
    {
        public int GCD(int a, int b)
        {
            //int x = 1;
            if (a == 0)
                return b;
            
            return GCD(b % a, a);
        }
        public static int GCDLoop(int a, int b) {
            int gcd = 1;
            for(int i = 1; i<=a && i <= b; i++)
            {
                if(a%i == 0 && b % i== 0)
                {
                    gcd = i;
                }
            }
            return gcd;

        }
    }
    class Emp
    {
        public int id;
        public string name;
        public string role;
        public Emp(int id, string name, string role)
        {
            this.id = id;
            this.name = name;
            this.role = role;
        }
    }
    class Car
    {
        public int id;
        public string brand;
        public string model;
        public int price;
        public Car(int id, string brand,string model,int price)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.price = price;
        }
        public Car() { }
    }
    class ClassCollections
    {
        dynamic collection;
        
        
        public ClassCollections(char c) 
        {
            switch (c)
            {
                case 'a':
                    collection = new ArrayList();
                    
                    break;
                case 'h':
                    collection = new Hashtable();
                    break;
                case 'q':
                    collection = new Queue();
                    break;
                case 's':
                    collection = new Stack();
                    break;
                case 'l':
                    Console.WriteLine("Enter Data type i, s");
                    string dt = Console.ReadLine().ToLower();
                    if(dt == "i")
                    {
                        collection = new LinkedList<int>();
                    }
                    else if(dt == "s")
                    {
                        collection = new LinkedList<string>();
                    }
                    break;
                case 'd':
                    collection = new Dictionary<string, int>();
                    break;
            }
            


            

        }
        public void PrintCollection()
        {
            Console.Write("[");
            foreach (dynamic i in collection)
            {
                if (i == collection.Count)
                {
                    Console.Write(i.ToString() + "");
                }
                Console.Write(i.ToString() + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        public void Operation(string o)
        {
            switch (o)
            {
                case "a":
                    Console.WriteLine("Enter number to add");
                    int a = Int32.Parse(Console.ReadLine());
                    collection.Add(a);
                    break;
                case "c":
                    Console.WriteLine(collection.Count);
                    break;
                case "r":
                    Console.WriteLine("Enter number to Remove");
                    int r = Int32.Parse(Console.ReadLine());
                    break;
                case "cl":
                    collection.Clear();
                    break;
                case "con":
                    Console.WriteLine("Enter value to search");
                    int s = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(collection.Contains(s));
                    break;
                case "p":
                    PrintCollection();
                    break;
            }
        }

    }

}
