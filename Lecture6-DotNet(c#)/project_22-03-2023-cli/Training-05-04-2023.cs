using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace project_22_03_2023_cli
{
    internal class Training_05_04_2023
    {
        
    }
    class Employee5
    {
        public int depId;
        public int id;
        public string name;
        public string role;
        public Employee5(int depId, int id, string name, string role) { 
            this.depId = depId;
            this.id = id;
            this.name = name;
            this.role = role;
        }
    }
    class FileCreate
    {
        String filePath = @"E:\KANINI\Lecture6-DotNet(c#)\project_22-03-2023-cli/";
        public FileCreate(string fileName)
        {
            filePath += fileName;
            if(File.Exists(filePath))
            {
                //File.Delete(filePath);

            }
            else
            {
                File.Create(filePath);
            }
        } 
        public String GetFilePath()
        {
            return filePath;
        }
    }

    class FileWordCount
    {
        public void FileWrite(string filePath)
        {
            StreamWriter stringWriter= new StreamWriter(filePath);
            Console.WriteLine("Enter something into file");
            stringWriter.WriteLine(Console.ReadLine());
            Console.WriteLine("");
            stringWriter.Close();
            return;
        }
        public void FileRead(string filePath)
        {
            StreamReader streamReader= new StreamReader(filePath);
            string line = "";
            string p = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                p += line;                
            }
            Console.WriteLine("");

            Console.WriteLine(p);
            streamReader.Close();
        }
        public void WordCount(string filePath, string word) { 
            StreamReader streamReader= new StreamReader(filePath);
            string line = "";
            int wordCount = 0;
            while((line = streamReader.ReadLine()) != null)
            {
                string[] wordArr = line.Split(' ');
                for(int i = 0; i<wordArr.Length; i++)
                {
                    if (wordArr[i].Equals(word))
                    {
                        wordCount++;
                    }

                }
            }
            if(wordCount == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("No Occurence of '{0}' in {1}",word, filePath);
            }
            else if(wordCount > 0) 
            {
                Console.WriteLine("'{0}' Occurence of '{1}' in '{2}'", wordCount, word, filePath);
            }
            streamReader.Close();
        }
    }
    class FileOperations
    {
        public void FileWrite(string filePath)
        {
            StreamWriter numWriter = new StreamWriter(filePath);
            Console.WriteLine("Enter number into File:");
            for(int i = 0; i<=5; i++)
            {
                numWriter.WriteLine(Int32.Parse(Console.ReadLine()));
            }
            numWriter.Close();
        }
        public void FileRead(string filePath)
        {
            StreamReader fileReader = new StreamReader(filePath);
            string line = "";
            Console.WriteLine(filePath);
            if(fileReader.ReadLine() == null)
            {
                Console.WriteLine("No data in file!");
                return;
            }
            Console.Write("[");
            while((line = fileReader.ReadLine()) != null) { 

                Console.Write(line +" ");
            }
            Console.WriteLine("]");


            fileReader.Close();
        }
        public void GetOddEven(string numPath, string oddPath, string evenPath)
        {
            StreamReader fileReader = new StreamReader(numPath);
            StreamWriter oddWriter = new StreamWriter(oddPath);
            StreamWriter evenWriter = new StreamWriter(evenPath);
            Console.WriteLine("separated");
            string line = "";
            while ((line = fileReader.ReadLine()) != null)
            {
                if (Int32.Parse(line) % 2 == 1)
                {
                    oddWriter.WriteLine(line);
                }
                else
                {
                    evenWriter.WriteLine(line);
                }
            }
            fileReader.Close();
            oddWriter.Close();
            evenWriter.Close();
        }
        public void GetPrimeNoPrime(string numPath, string primePath, string noPrimePath)
        {
            StreamReader fileReader = new StreamReader(numPath);
            StreamWriter primeWriter = new StreamWriter(primePath);
            StreamWriter noPrimeWriter = new StreamWriter(noPrimePath);
            Console.WriteLine("separated");
            string line = "";
            while ((line = fileReader.ReadLine()) != null)
            {
                bool flag = true;
                for(int i = 2; i <= Math.Sqrt(Int32.Parse(line)); i++)
                {
                    if(Int32.Parse(line) % i == 0)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if(flag)
                {
                    primeWriter.WriteLine(line);
                }
                else
                {
                    noPrimeWriter.WriteLine(line);
                }
            }
            fileReader.Close();
            noPrimeWriter.Close();
            primeWriter.Close();
        }
    }
}
