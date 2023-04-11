using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace project_22_03_2023_cli
{
    internal class test_10_04_2023
    {
        public void Pattern(int n)
        {
            for(int i = 1; i <= n; i++) { 
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(j.ToString() + " ");
                }Console.WriteLine();
            }
        }
        public void Amstrong(int n)
        {
            int temp = n;
            double ams = 0;
            while(temp > 0)
            {
                ams += Math.Pow((temp % 10), (n.ToString()).Length);
                temp /= 10;
            }
            if(ams == n)
            {
                Console.WriteLine("{0} is amstrong", n);
            }
            else
            {
                Console.WriteLine("{0} is not amstrong", n);
            }

        }
        public override string ToString()
        {
            test_10_04_2023 t = new test_10_04_2023();
            return t.ToString();
        }
    }
    class TemperatureCoversion
    {
        public TemperatureCoversion()
        {
            bool te_co = true;
            do
            {
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("Press 0 to convert Celsius to Farenheit");
                Console.WriteLine("Press 1 to convert Farenheit to Celsius");
                int act = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Temperature");
                double t = Double.Parse(Console.ReadLine());
                bool t_c = true;
                do
                {
                    if (act == 0)
                    {
                        Console.WriteLine("Temperature in Farenheit " + CelToFar(t));
                        t_c = false;
                    }
                    else if (act == 1)
                    {
                        Console.WriteLine("Temperature in Celsius " + FarToCel(t));
                        t_c = false;
                    }
                    else
                    {
                        t_c = true;
                    }
                } while (t_c);

                Console.WriteLine("Enter Y/N");
                string a = Console.ReadLine().ToLower();
                bool y_n = true;
                do
                {
                    if (a.Equals("y"))
                    {
                        te_co = true;
                        y_n = false;
                    }
                    else if(a.Equals("n")) { 
                        te_co= false;
                        y_n = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter between Y/N");
                        y_n = true;
                    }
                }while(y_n);
            }while(te_co);

        }
        public double CelToFar(double t)
        {
            return (t * 9 / 5) + 32;
        }
        public double FarToCel(double t)
        {
            return (double)((double)5/9 * (t - 32));
        }
    }
    class FileHandling
    {
        string filepath = @"E:\KANINI\Lecture6-DotNet(c#)\project_22-03-2023-cli\";
        static int id = 0;
        static string[] role = new string[] { "HR", "TL", "Dev" };
        static string name = "name";   
        public FileHandling()
        {
            bool f_h = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("File Handling");
                Console.WriteLine("Press 'C' create File");
                Console.WriteLine("Press 'W' to write into existing file");
                Console.WriteLine("Press 'D' to display lines file");
                Console.WriteLine("Press 'S' to separate HR & TL");
                string action = Console.ReadLine().ToLower();
                switch (action)
                {
                    case "c":
                        Console.WriteLine("Enter File Name");
                        string filenamecreate = Console.ReadLine();
                        CreateFile(filepath + filenamecreate);
                        break;
                    case "w":
                        Console.WriteLine("Enter file name to edit");
                        string filenamewrite = Console.ReadLine();
                        FileWrite(filepath + filenamewrite);
                        break;
                    case "d":
                        Console.WriteLine("Enter file name to display");
                        string filenamaeread = Console.ReadLine();
                        FileRead(filepath + filenamaeread);
                        break;
                    case "s":
                        FileSeparate(filepath + "Employee.txt", filepath + "Hr.txt", filepath + "Tl.txt" );
                        break;
                }
                Console.Write("Enter Y/N");
                bool y_n = true;
                do
                {
                    string a = Console.ReadLine().ToLower();
                    if (a.Equals("y"))
                    {
                        f_h = true;
                        y_n = false;
                    }
                    else if (a.Equals("n"))
                    {
                        f_h = false;
                        y_n = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter between Y/N");
                        y_n = true;

                    }
                } while (y_n);
            }
            while (f_h);
        }
        public void CreateFile(string filename)
        {
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exists at {0}", filename);
            }
            else
            {
                File.Create(filename);
                Console.WriteLine("Created");
            }
        }
        public string GetFilePath()
        {
            return this.filepath;
        }
        public void FileWrite(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            Random r = new Random();

            Console.WriteLine("Enter number of records to enter");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                sw.WriteLine((++id).ToString() + " " + name + id.ToString() + " " + role[r.Next(0, 2)]);
            }            
            sw.Close();
        }
        public void FileRead(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        public void FileSeparate(string emp, string hr, string tl)
        {
            StreamReader sr = new StreamReader(emp);
            StreamWriter hrw = new StreamWriter(hr);
            StreamWriter tlw = new StreamWriter(tl);
            String line = sr.ReadLine();
            while(line != null)
            {
                string[] employee = line.Split(' ');
                if (employee[2].Equals("HR"))
                {
                    hrw.WriteLine(line);
                }
                else if (employee[2].Equals("TL"))
                {
                    tlw.WriteLine(line);
                }
                line= sr.ReadLine();
            }
            sr.Close();
            hrw.Close();
            tlw.Close();
            return ;
        }
    }
    class VoterEligibility : Exception
    {
        int age;
        public VoterEligibility(int age)
        {
            this.age = age;
            GetEligibility();
        }
        public VoterEligibility(string message)
        {
        }
        
        public void GetEligibility()
        {
            try
            {
                if (this.age > 18)
                {
                    Console.WriteLine("Enter Vote");
                    Console.WriteLine("Press a to vote abk");
                    Console.WriteLine("Press d to vote dbk");
                    Console.WriteLine("Press n to vote nota");
                    string vote = Console.ReadLine();
                    Console.WriteLine("Voted to {0}", vote);
                }
                else
                {
                    throw new VoterEligibility("Under 18");
                }
            }
            catch(VoterEligibility e) { Console.WriteLine(e.Message); }
            finally
            {
                Console.WriteLine("After e being caught");
            }
        }

    }
    class AdvancedMath
    {
        public AdvancedMath()
        {
            bool a_m = true;
            do
            {
                Console.WriteLine("Press 'ma' to get max of two numbers");
                Console.WriteLine("Press 'mi' to get min of two numbers");
                Console.WriteLine("Press 'a' to get abs of a number");
                Console.WriteLine("Press 'p' to get pow of two numbers");
                Console.WriteLine("Press 's' to get sqrt of a number");
                string s = Console.ReadLine().ToLower();
                switch (s)
                {
                    case "ma":
                        Console.WriteLine("Enter Two numbers");
                        Console.WriteLine(Math.Max(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
                        break;
                    case "mi":
                        Console.WriteLine("Enter Two numbers");
                        Console.WriteLine(Math.Min(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
                        break;
                    case "a":
                        Console.WriteLine("Enter a number");
                        Console.WriteLine(Math.Abs(Double.Parse(Console.ReadLine())));
                        break;
                    case "p":
                        Console.WriteLine("Enter two numbers");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Pow(n1, n2));
                        break;
                    case "s":
                        Console.WriteLine("Enter a number");
                        Console.WriteLine(Math.Sqrt(Int32.Parse(Console.ReadLine())));
                        break;
                }
                Console.Write("Enter Y/N");
                bool y_n = true;
                do
                {
                    string a = Console.ReadLine().ToLower();
                    if (a.Equals("y"))
                    {
                        a_m = true;
                        y_n = false;
                    }
                    else if (a.Equals("n"))
                    {
                        a_m = false;
                        y_n = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter between Y/N");
                        y_n = true;

                    }
                } while (y_n);
            }
            while (a_m);
        }
    }
}
