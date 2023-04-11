using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Training_27_03_2023
    {
        public void BuildJaggedArray()
        {
            Console.WriteLine("Build a Jagged Array");
            Console.WriteLine("Enter N");
            int N = Int32.Parse(Console.ReadLine());
            int[][] jArr = new int[N][];
            for(int i= 0; i<N; i++)
            {
                Console.WriteLine("Enter M");
                int M = Int32.Parse(Console.ReadLine());
                jArr[i] = new int[M];
                for (int j = 0; j<M; j++)
                {
                    Console.WriteLine("Enter value {0}, {1}" ,i,j);
                    jArr[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write("[");
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    if(j == jArr[i].Length - 1)
                    {
                        Console.Write(jArr[i][j]);
                        break;
                    }
                    Console.Write(jArr[i][j] + ", ");
                }
                Console.Write("],");
                Console.WriteLine();

            }
        }
    }
    class Student
    {
        string sId;
        string sName;
        
        public Student(string sId, string sName)
        {
            this.sId = setId(sId);
            this.sName = setName(sName);            
        }
        private string setId(string sId)
        {
            return sId;
        }
        private string setName(string sName)
        {
            return sName;
     
        }
        public string getId()
        {
            return this.sId;
        }
        public string getName()
        {
            return this.sName;
        }
        public int getMarks(MarkDB m)
        {
            return m.getTotal();
        }
    }
     class MarkDB
    {
        int eng;
        int math;
        int phy;
        int sId;


        public MarkDB(int sId, int eng, int math, int phy)
        {
            this.eng = eng;
            this.math = math;
            this.phy = phy;
            this.sId = sId;
        }
        public int getEng()
        {
            return this.eng;
        }
        public int getMath()
        {
            return this.math;
        }
        public int getPhy()
        {
            return this.phy;
        }
        public int getTotal()
        {
            return (this.eng + this.math + this.phy);
        }
       
    }


    class Employee
    {
        string empname;
        int empnum;
        int empnetsalary;
        int empgrosssalary;
        int bp;
        int da;
        int pf;
        public void getDetails()
        {
            Console.WriteLine("Enter Employee Name");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Number");
            empnum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Basic Pay ");
            bp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Da Percentage ");
            da = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee  Pf ");
            pf = Int32.Parse(Console.ReadLine());



        }
        public int calculateGrossSalary()
        {
            empgrosssalary = bp + daa();

            return empgrosssalary;
        }

        public int daa()
        {
            int daa = (bp * da) / 100;
            return daa;
        }


        public int calculateNetSalary()
        {
            empnetsalary = bp + daa() - pf;

            return empnetsalary;
        }

        public void display()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("****Employee Detail***");
            Console.WriteLine("====================================");
            Console.WriteLine("Name :" + empname);
            Console.WriteLine("Employee Number :" + empnum);

            Console.WriteLine("====================================");
            Console.WriteLine("****Salary Breakdown****");
            Console.WriteLine("====================================");
            Console.WriteLine("Employee Gross salary :" + calculateGrossSalary());
            Console.WriteLine("Employee Net  salary :" + calculateNetSalary());
            Console.WriteLine("=============Thank You==============");
        }
    }
    class Calculator
    {

        int a;
        int b;
        int C;

        public void setData()
        {
            Console.WriteLine("Enter value of a");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter vlaue of c");
            C = Int32.Parse(Console.ReadLine());
        }

        public void add()
        {
            int c = a + b + C;

        }
    }

}


/*Property*/

class Property
{
    private int value;
    public int Value
    {
        set
        {
            this.value = value;
        }
        get
        {
            return this.value;
        }
    }
}

class CurrencyConverter
{
    
    
    public double Converter()
    {
        Console.WriteLine("Enter Currency: ");
        double curr = double.Parse(Console.ReadLine());
        Console.WriteLine("For Dollar to Rupee Type  `D`");
        Console.WriteLine("For Rupee to Dollar Type  `R`");
        String s = Console.ReadLine().ToLower();
        double res = 0;
        switch(s)
        {
            case "d":
                res =  curr * 82.36;
                break;
            case "r":
                res = curr / 82.36;
                break;
        }
        return res;
    }
}
