using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Dynamic;

namespace project_22_03_2023_cli
{
    class CreateArr
    {
        private int n;
        private int[] arr;
        private bool b;
        public CreateArr(int n)
        {
            arr = new int[n];
            ArrValueGenerate();
        }
        public void ArrValueGenerate()
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 9);
            }
        }
        public void SetB()
        {
            b = true;
        }
        public bool GetB()
        {
            return b;
        }
        public int[] GetArr()
        {
            return arr;
        }
    }
    class ArrayOP
    {
        
        public void PrintArr(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)

            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "]");
                    break;
                }
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        public int[] ArrDelByValue(int[] arr, int val)
        {
            int count = 0;
            int[] arrvalind = new int[arr.Length];
            for (int i = 0; i < arrvalind.Length; i++)
            {
                arrvalind[i] = -1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    arrvalind[count] = i;
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total number of records found: {0}", count);
            Console.WriteLine();
            bool y_n = true; ;
            do
            {
                Console.WriteLine("Press '1' for Deleting First occurence of Data");
                Console.WriteLine("Press '0' for Deleting All occurence of Data");
                Console.WriteLine("press 'M' for manual input");
                string s = Console.ReadLine();
                Console.WriteLine();
                bool m_0_1 = true;

                while (m_0_1)
                {
                    if (s == "1")
                    {
                        arr[arrvalind[0]] = -1;
                        ArrSwap(arr, arrvalind[0]);
                        m_0_1 = false;
                        y_n = false;
                    }
                    else if (s == "0")
                    {
                        for (int i = count - 1; i >= -1; i--)
                        {

                            if (i == -1)
                            {
                                m_0_1 = false;
                                break;
                            }
                            else if (arrvalind[i] == -1)
                            {
                                continue;
                            }
                            arr[arrvalind[i]] = -1;
                            arr = ArrSwap(arr, arrvalind[i]);
                        }
                        y_n = false;


                    }
                    else if (s == "m")
                    {
                        bool b ;
                        do
                        {
                            Console.WriteLine("Enter number of records to delete");
                            int m = Int32.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (m > count)
                            {
                                Console.WriteLine("Manual input should be less than or equal to the available data");
                                Console.WriteLine();
                                b = true;
                                y_n = true;
                            }
                            else if (m <= 0)
                            {
                                Console.WriteLine("Manual input should be greater than Zero");
                                Console.WriteLine();
                                b = true;
                                y_n = true;
                            }
                            else
                            {
                                int t = m;
                                for (int i = count - 1; i >= 0; i--)
                                {
                                    if (t == 0)
                                    {
                                        m_0_1 = false;
                                        //b = false;
                                        break;
                                    }
                                    Console.WriteLine(i.ToString() + " "+ arrvalind[i].ToString()+ " "+ arr[arrvalind[i]]);
                                    arr[arrvalind[i]] = -1;
                                    arr = ArrSwap(arr, arrvalind[i]);
                                    t--;
                                }
                                b = false;
                                y_n = false;
                            }
                        }
                        while (b);
                    }
                    else
                    {
                        Console.WriteLine("Enter between '0'/'1'/'M'");
                        m_0_1 = false;
                        y_n = true;
                    }
                }
            }
            while (y_n);
            return arr;
        }
        

        public void ArrSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
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
        public int[] ArrayDelByKey(int[] arr, int key)
        {
            if (key >= arr.Length)
            {
                Console.WriteLine("Position not found");
                return arr;
            }
            else
            {
                arr[key] = -1;
                ArrSwap(arr, key);
            }
            return arr;
        }
        public int[] ArrSwap(int[] arr, int index)
        {
            for (int i = index; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    break;
                }
                arr[i] = arr[i] + arr[i + 1];
                arr[i + 1] = arr[i] - arr[i + 1];
                arr[i] = arr[i] - arr[i + 1];
            }

            return arr;
        }

    }
    internal class Training_30_03_2023
    {
        public int[] ArrValueGenerate(int[] arr)
        {
            Random rand = new Random();
            for(int i= 0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(0, 2);
            }
            return arr;
        }
        
        
        
        public string AbbreviationGen(String s)
        {
            string[] sArr = s.Split(' ');
            string res = "";
            for (int i = 0; i < sArr.Length; i++)
            {
                if (i == sArr.Length-1)
                {
                    res += sArr[i].Substring(0, 1).ToUpper();
                    break;
                }
                else
                {
                    res += sArr[i].Substring(0, 1).ToUpper() + ".";
                }
            }
            return res;
        }
        public string Abb(string s)
        {
            s = s.Trim();
            string res = s[0].ToString().ToUpper() + '.';
            char c = s[0];
            for(int i = 1; i < s.Length-1; i++)
            {
                if (c == ' ' & s[i] == ' ')
                {
                }
                else if (c == ' ' & s[i] != ' ')
                {

                    res += s[i].ToString().ToUpper() + ".";

                }
                c = s[i];
            }
            res = res.Substring(0,res.Length-1);
            return res;
        }
        
    }
    class CurrencySet
    {
        public readonly string currency;
        public CurrencySet()
        {
            /* currency = ConfigurationSettings.AppSettings["Dollar"];
             Console.WriteLine(currency);*/
            currency = "Dollar";
        }
        public CurrencySet(string currency)
        {
            this.currency = currency;
        }
        
    }

    /* Abstract*/
    
     

    public abstract class Anna_University
    {
        private protected static string[] BE_Stream = new string[5] { "CSE", "IT", "Mechanical", "Mechatronics", "Civil" };
        private protected static int[] BE_Stream_Availability = new int[5] { 5, 5, 5, 5, 5 };
        private protected int register_no;
        private protected string degree_stream;
        private protected int fees_structure;
        public abstract void SetReg(int reg_no); 
        public abstract int GetReg();
        public abstract string GetDegree();
        public abstract void SetDegree(string[] degree);

        public abstract int fees_payment();
        public abstract bool Certificate_Verification(Aadhar aadhar, MarkSheet marksheet);
    }

    class Student_AU
    {
        private int register_no;
        private string name;
        private int age;
        private string college_name;
        private string course_stream;
        
    }
    
    public class Aadhar
    {
        private string aadhar_no;
        private string name;
        private bool biometrics;

        public Aadhar(string fName, string lName, bool biometrics)
        {
            this.aadhar_no = SetAadharNo();
            this.name = fName + " " + lName;
            this.biometrics = biometrics;
        }
        private string SetAadharNo()
        {
            Random r = new Random();
            return (r.Next(1000,9999).ToString() + r.Next(1000, 9999).ToString() + r.Next(1000, 9999).ToString() + r.Next(1000, 9999).ToString());
        }
        public string GetAadharNo()
        {
            return aadhar_no;
        }
        public string GetName()
        {
            return name;
        }
        public bool GetBiometrics()
        {
            return biometrics;
        }
        
    }
    public class MarkSheet
    {
        private int roll_no;
        private string name;
        private int total;
        private int tamil;
        private int english;
        private int maths;
        private int physics;
        private int chemistry;
        private int cs;

        public MarkSheet(int roll_no, string name, int tamil, int english, int maths, int physics, int chemistry, int cs)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.tamil = tamil;
            this.english = english;
            this.maths = maths;
            this.physics = physics;
            this.chemistry = chemistry;
            this.cs = cs;
            this.total = TotalCalc();
        }
        private int TotalCalc()
        {
            return this.tamil + this.english+ this.maths + this.physics + this.chemistry + this.cs;
        }
        public int GetRollNo()
        {
            return roll_no;
        }
        public string GetName()
        {
            return name;
        }
        public int GetTotal()
        {
            return total;
        }
        public int GetTamil()
        {
            return tamil;
        }
        public int GetEnglish()
        {
            return english;
        }
        public int GetMaths()
        {
            return maths;
        }
        public int GetPhysics()
        {
            return physics;
        }
        public int GetChemistry()
        {
            return chemistry;
        }
        public int GetCS()
        {
            return cs;
        }
    }
    class College1 : Anna_University
    {
        private const int cutoff = 70;
        public override bool Certificate_Verification(Aadhar aadhar, MarkSheet marksheet)
        {
            bool verification_progress = false;
            if(aadhar.GetName() == marksheet.GetName())
            {
                if(marksheet.GetTamil() > 50 && marksheet.GetEnglish() > 50 && marksheet.GetMaths() > 50 && marksheet.GetPhysics() > 50 && marksheet.GetChemistry() > 50 && marksheet.GetCS() > 50)
                {
                    if((marksheet.GetMaths() + (marksheet.GetPhysics() + marksheet.GetChemistry())/2)/2 > 70){ 
                        verification_progress =true;
                    }
                    else
                    {
                        Console.WriteLine("Student Cutoff didn't meet expectations");
                    }
                }
            }
            else
            {
                Console.WriteLine("Names dont match");
            }


            return verification_progress;
        }

        public override int fees_payment()
        {

            return 0;
        }

        public override string GetDegree()
        {
            return degree_stream;
        }

        public override int GetReg()
        {
            return register_no;
        }

        public override void SetDegree(string[] degreePref)
        {
            string alot = degreePref[0];
            for(int i = 1; i< degreePref.Length; i++) { 
                for(int j = 0, k = BE_Stream.Length -1; j <= (BE_Stream.Length - 1) / 2 && k >= (BE_Stream.Length -1) / 2; j++, k-- )
                {
                    if (alot == BE_Stream[j] && BE_Stream_Availability[j] > 0) { 
                        degree_stream = BE_Stream[j];
                        BE_Stream_Availability[j]--;
                        break;
                    }
                    else
                    {
                        alot = degreePref[i];
                    }
                    if(alot == BE_Stream[k] && BE_Stream_Availability[k] > 0)
                    {
                        degree_stream = BE_Stream[k];
                        BE_Stream_Availability[k]--;
                        break;
                    }
                    else
                    {
                        alot = degreePref[i];
                    }
                }
            }
            if(degree_stream == null ) {
                Console.WriteLine("Course is Unavailable");
            }
        }

        public override void SetReg(int reg_no)
        {
            register_no = reg_no;
        }
    }

}
