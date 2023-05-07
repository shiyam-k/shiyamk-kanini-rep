using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EF_Code_First_26_04_2023.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_Code_First_26_04_2023
{
    internal class EF_Code_First_Operations 
    {
        public static SupportClass support = new SupportClass();
        Course c = new Course();
        Students s = new Students();
        public EF_Code_First_Operations()
        {
            Console.WriteLine("Enter I to Insert");
            switch (support.GetStringInput("Key:", new List<string>() { "i" }))
            {
                case "i":
                    InsertRow();
                    break;
            }

        }
        void InsertRow()
        {
            CourseContext context = new CourseContext();
            ArrayList data = new ArrayList();
            Console.WriteLine("Press 1 to Insert Course Table");
            Console.WriteLine("Press 2 to Insert Student Table");
            if ((support.GetStringInput("Key", new List<string> { "1", "2" })) == "1")
            {
                var columnnames = from t in typeof(Course).GetProperties() select t.Name;

                foreach (var column in columnnames)
                {
                    if (column.ToString().Equals("CId"))
                    {
                        continue;
                    }
                    else if (column.ToString().Equals("CName"))
                    {
                        c.CName = support.GetStringInput("Course Name:");
                        
                    }
                    else if (column.ToString().Equals("CDuration"))
                    {
                        c.CDuration = support.GetNumberInput("Course Duration");
                    }
                }
                context.Courses.Add(c);
                context.SaveChanges();
            }
            else
            {
                var columnnames = from t in typeof(Students).GetProperties() select t.Name;
                foreach (var column in columnnames)
                {
                    if (column.ToString().Equals("SId"))
                    {
                        continue;
                    }
                    else if (column.ToString().Equals("course"))
                    {
                        var courseList = from t in context.Courses select new { cName = t.CName, cID = t.CId };
                        foreach (var course in courseList)
                        {
                            Console.WriteLine(course.cID.ToString() + " " + course.cName);
                        }
                        data.Add(support.GetNumberInput(column.ToString()));
                    }
                    else
                    {
                        data.Add(support.GetStringInput(column.ToString()));
                    }
                }
                foreach(var row in data)
                {
                    Console.WriteLine(row.ToString());
                }
                s = new Students()
                {
                    SName = data[0].ToString(),
                    CId = data[1],
                    
                };
                context.Students.Add(s);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Data Row updated");
        }
    }
    
}
