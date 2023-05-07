using DBfirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBfirst
{
    internal class DbFirstOperations
    {
        static SupportClassLibrary.Class1 support = new SupportClassLibrary.Class1();
        
        public DbFirstOperations() 
        {
            bool y_n = true;
            do
            {
                Console.WriteLine("Press i to insert");
                Console.WriteLine("Press s to select");
                Console.WriteLine("Press u to update");
                Console.WriteLine("Press d to delete");
                switch (support.GetStringInput("Choose from above:", new List<string> { "i", "s", "u", "d" }))
                {
                    case "i":
                        Insert();
                        break;
                        case "s":
                            Select();
                            break;
                        case "u":
                            Update();
                            break;
                        case "d":
                            Delete();
                            break;
                }
                y_n = support.Yes_No();
            }
            while(y_n);
        }
        public void Insert()
        {
            string table = GetTableNameForCRUD();
            //Console.WriteLine(table);
            if (table.Equals("Doctors"))
            {
                InsertDoctor();
            }
            else if (table.Equals("Patients"))
            {
                InsertPatient();
            }
            else
            {
                Console.WriteLine("Enter the valid table name");
                Insert();
            }
        }
        public void InsertDoctor()
        {
            using(HospitalDbContext hospitalDbContext = new HospitalDbContext())
            {
                Doctor d = new Doctor()
                {
                    Dname = support.GetStringInput("Enter Doctor Name to Add"),
                };
                hospitalDbContext.Doctors.Add(d);
                hospitalDbContext.SaveChanges();
                Console.WriteLine("Inserted");
            }            
        }
        public void InsertPatient()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    var doctors = hospitalDbContext.Doctors.ToList();
                    List<string> doctorList = new List<string>();
                    foreach (var doctor in doctors)
                    {
                        doctorList.Add(doctor.Did.ToString());
                    }
                    Patient p = new Patient()
                    {
                        Pname = support.GetStringInput("Enter Patient name"),
                        DoctorsD = hospitalDbContext.Doctors.Find(Int32.Parse(support.GetStringInput("Enter Doctor Id:", doctorList))),
                    };
                    hospitalDbContext.Patients.Add(p);
                    hospitalDbContext.SaveChanges();
                    Console.WriteLine("Inserted");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string GetTableNameForCRUD()
        {
            List<string> Tables = new List<string>();
            using (HospitalDbContext hospitalContext = new HospitalDbContext())
            {
                Tables = hospitalContext.Database.SqlQuery<string>($"SELECT name FROM sys.tables ORDER BY name").ToList();
            }
            int index = 0;
            string resTab = "";
            Tables.Remove("__EFMigrationsHistory");
            Console.WriteLine("Choose from below");
            Console.WriteLine("============");
            foreach (string table in Tables)
            {
                Console.WriteLine($"{++index} {table.ToString()} ");
            }
            Console.WriteLine("============");
            List<string> res = new List<string>();
            for (int i = 1; i <= index; i++)
            {
                res.Add(i.ToString());
            }
            string choice = support.GetStringInput("", res);
            for (int i = 0; i < index; i++)
            {
                if (Int32.Parse(choice) == Int32.Parse(res[i]))
                {
                    resTab = Tables[i];
                }
            }
            return resTab;
        }
        public void Select()
        {
            Console.WriteLine("Select table to View");
            string table = GetTableNameForCRUD();
            if (table.Equals("Doctors"))
            {
                ViewDoctor();
            }
            else if (table.Equals("Patients"))
            {
                ViewPatient();
            }
        }
        public void ViewDoctor()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    Console.WriteLine("press 1 to Select all");
                    Console.WriteLine("press 2 to Select by Id");
                    switch (support.GetStringInput("Choose from above", new List<string> { "1", "2" }))
                    {
                        case "1":
                            IEnumerable<Doctor> res = hospitalDbContext.Doctors.ToList();
                            foreach (var r in res)
                            {
                                Console.WriteLine(r.Did + " " + r.Dname);
                            }
                            break;
                        case "2":
                            Doctor doc = hospitalDbContext.Doctors.Find(support.GetNumberInput("Enter DoctorId to choose"));
                            Console.WriteLine(doc.Did + " " + doc.Dname);
                            break;

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void ViewD() 
        {
            using(HospitalDbContext hospitalDbContext = new HospitalDbContext())
            {
                IEnumerable<Doctor> res = hospitalDbContext.Doctors.ToList();
                foreach (var r in res)
                {
                    Console.WriteLine(r.Did + " " + r.Dname);
                }
            }
        }
        public void ViewP()
        {
            using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
            {
                IEnumerable<Patient> res = hospitalDbContext.Patients.ToList();
                foreach (var r in res)
                {
                    Console.WriteLine(r.Pid + " " + r.Pname + " " + r.DoctorsD);
                }
            }
        }
        public void ViewPatient()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    Console.WriteLine("press 1 to select all");
                    Console.WriteLine("press 2 to select by patient Id");
                    Console.WriteLine("press 3 to select by Doctors");
                    switch (support.GetStringInput("Choose from above", new List<string>() { "1", "2", "3" }))
                    {
                        case "1":
                            IEnumerable<Patient> res = hospitalDbContext.Patients.ToList();
                            foreach (var r in res)
                            {
                                Console.WriteLine(r.Pid + " " + r.Pname + " " + r.DoctorsD);
                            }
                            break;
                        case "2":
                            Patient pat = hospitalDbContext.Patients.Find(support.GetNumberInput("Enter Patient Id to choose"));
                            Console.WriteLine(pat.Pid + " " + pat.Pname + " " + pat.DoctorsD);
                            break;
                        case "3":
                            Patient pat1 = (Patient)hospitalDbContext.Database.SqlQuery<string>($"Select * from Patients where DoctorsDId = '{support.GetNumberInput("Enter Doctor Id to search")}'");
                            Console.WriteLine(pat1.Pid + " " + pat1.Pname + " " + pat1.DoctorsD);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Update()
        {
            Console.WriteLine("Select table to Update");
            string table = GetTableNameForCRUD();
            if (table.Equals("Doctors"))
            {
                UpdateDoctor();
            }
            else if (table.Equals("Patients"))
            {
                UpdatePatient();
            }
        }
        public void UpdateDoctor()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    ViewD();
                    var doctor = hospitalDbContext.Doctors.Find(support.GetNumberInput("Enter doctor id to update"));
                    doctor.Dname = support.GetStringInput("Enter Name :");
                    hospitalDbContext.Doctors.Update(doctor);
                    hospitalDbContext.SaveChanges();
                    ViewD();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdatePatient()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    ViewP();
                    var patient = hospitalDbContext.Patients.Find(support.GetNumberInput("Enter Patient id to update"));
                    patient.Pname = support.GetStringInput("Enter Name :");
                    hospitalDbContext.Patients.Update(patient);
                    hospitalDbContext.SaveChanges();
                    ViewP();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete()
        {
            Console.WriteLine("Select table to Delete");
            string table = GetTableNameForCRUD();
            if (table.Equals("Doctors"))
            {
                DeleteDoctor();
            }
            else if (table.Equals("Patients"))
            {
                DeletePatient();
            }
        }
        public void DeleteDoctor()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    ViewD();
                    var doctor = hospitalDbContext.Doctors.Find(support.GetNumberInput("Enter doctor id to Delete"));
                    hospitalDbContext.Doctors.Remove(doctor);
                    hospitalDbContext.SaveChanges();
                    ViewD();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeletePatient()
        {
            try
            {
                using (HospitalDbContext hospitalDbContext = new HospitalDbContext())
                {
                    ViewP();
                    var patient = hospitalDbContext.Patients.Find(support.GetNumberInput("Enter patient id to Delete"));
                    hospitalDbContext.Patients.Remove(patient);
                    hospitalDbContext.SaveChanges();
                    ViewP();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
