using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    class Class_Assignment
    {
        public int GetOneInput()
        {
            Console.WriteLine("Enter input");
            int n = Int32.Parse(Console.ReadLine());
            return n;
        }
        public void PrintArr(int [] arr)
        {
            Console.Write("[");
            for(int i = 0; i<arr.Length; i++)

            {
                if(i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "]");
                    break;
                }
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        public int [] GetArr()
        {
            Console.WriteLine("Enter Array Size");
            int n = Int32.Parse(Console.ReadLine());
            int [] arr  = new int[n];
            for(int i = 0; i<n; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            return arr;
        }

        public void ArrSort(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                for(int j = 0; j <i+1; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }
            PrintArr(arr);
        }
        public void RevArr(int[]arr) {
            Console.Write("[");
            for(int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]+ ", ");
            }
            Console.Write("]"); 
        }
        public void RemDup(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length ; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        //Console.WriteLine(Arr[i]);
                        arr[j] = 0;
                        ;
                    }
                }
            }
            PrintArr(arr);

        }
        public int ArrSum(int[] arr,int n)
        {
            if(n == arr.Length)
            {
                return 0;
            }
            return arr[n] + ArrSum(arr, n+1);
        }
        public void IsPal(int num)
        {
            int numDup = 0;
            int t = num;
            while(t > 0)
            {
                numDup *= 10;
                numDup += t % 10;
                
                t /= 10;
            }
            if(numDup == num)
            {
                Console.WriteLine("{0} is Palindrome", num);
            }
            else
            {
                Console.WriteLine("{0} is not Palindrome", num);
            }
        }
        public void PrintOdd(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 1 & i < arr.Length - 1) 
                {
                    Console.Write(arr[i] + ", ");
                }
                else if (arr[i] % 2 == 1)
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write("]");
        }
    }
}
