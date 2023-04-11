using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_22_03_2023_cli
{
    internal class Test_06_04_2023
    {
        public void Pattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("*");

                }Console.WriteLine();
            }
        }
    }
    public class EB
    {
        const int pricePerUnit = 7;
        public int ebId;
        public string name;
        public int unit;
        HouseDet ebHouse = new HouseDet();
        public void GetEBHouse()
        {
            ebHouse = Program.GetHouseDetails(this.name);
            Console.WriteLine(ebHouse.hasElectricityAccess);
        }
        public EB(int ebId, string name)
        {
            this.ebId = ebId;
            this.name = name;
            this.unit = EnterReading();
        }
        
        public int EnterReading()
        {
            int u = 0;
            if (ebHouse.hasElectricityAccess)
            {
                if (ebHouse.hasFan)
                {
                    u += 5;
                }
                if (ebHouse.hasWashingMachine)
                {
                    u += 7;
                }
                if (ebHouse.hasAC)
                {
                    u += 20;
                }
                if (ebHouse.hasTV)
                {
                    u += 15;
                }
            }
            else
            {
                unit = 0;
            }
            return u;
        }
        public int CalculateBill()
        {
            return EnterReading() * pricePerUnit;
        }

    }
    public class HouseDet
    {
        public HouseDet()
        {

        }
        public string name;
        public bool hasElectricityAccess;
        public bool hasTV;
        public bool hasFan;
        public bool hasAC;
        public bool hasWashingMachine;
        public HouseDet(string name, bool hasElectricityAccess, bool hasTV, bool hasFan, bool hasAC, bool hasWashingMachine)
        {
            this.name = name;
            this.hasElectricityAccess = hasElectricityAccess;
            this.hasTV = hasTV;
            this.hasFan = hasFan;
            this.hasAC = hasAC;
            this.hasWashingMachine= hasWashingMachine;
        }
    }
    class Players
    {
        public int Player_Id;
        public string Player_Name;
        public int Team_Id;
        public string Player_City;
        public Players(int Player_Id, string Player_name, int Team_Id, string Player_City)
        {
            this.Player_Id = Player_Id;
            this.Player_Name = Player_name;
            this.Team_Id = Team_Id;
            this.Player_City = Player_City;
        }
    }
    partial class Calc
    {
        public void Display()
        {
            Console.WriteLine("Calculator");
        }
    }
    partial class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    partial class Calc
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    partial class Calc
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    partial class Calc
    {
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
    public class IdGen
    {
        public static int id;

        
        static IdGen()
        {
            
            id++;
            Console.WriteLine($"id={id}");
        }
        public IdGen()
        {
            if(id > 0)
            {
                id++;
                Console.WriteLine($"id={id}");
            }
        }
        
    }
}
