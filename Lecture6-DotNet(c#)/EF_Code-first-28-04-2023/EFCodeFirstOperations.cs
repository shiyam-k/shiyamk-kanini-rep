using EF_Code_first_28_04_2023.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace EF_Code_first_28_04_2023
{
    internal class EFCodeFirstOperations
    {

        List<Type> tableRef = new List<Type>();
        static HospitalContext hospitalContext = new();
        static SupportClass support = new SupportClass();
        static List<string> Tables = hospitalContext.Database.SqlQuery<string>($"SELECT name FROM sys.tables ORDER BY name").ToList();
        /*static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog = HospitalDB; Integrated Security = True";
        public static SqlConnection connection = new SqlConnection(connectionSource);*/
        
        public EFCodeFirstOperations()
        {
            Console.WriteLine("Press i to Insert");

            switch (support.GetStringInput("Key:", new List<string>() { "i" }))
            {
                case "i":
                    InsertRecord();
                    break;
            }
        }
        public void InsertRecord()
        {
            string table = GetTableNameForCRUD();
            
            if(table != null)
            {
                Insert(table);
            }
            else
            {
                Console.WriteLine("No Table Exists");
            }
            
        }

        public string GetTableNameForCRUD()
        {
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
        /*public List<string> GetTableColumn(string tableName)
        {
            using (HospitalContext ne = new HospitalContext())
            {
                var entityType = hospitalContext.Model.GetEntityTypes().FirstOrDefault(t => t.GetTableName() == tableName);
                if (entityType == null)
                {
                    throw new ArgumentException($"Table '{tableName}' not found in the context.");
                }
                var columnNames = entityType.GetProperties().Select(p => $"{p.GetColumnName()}").ToList();

                return columnNames;
            }
        }*/
        public void Insert(string table)
        {
            //List<string> columns = GetTableColumn(table);
            /*List<string> types = GetColumnDType(table);
            columns = GetTableColumn(table);
            var columnsAndTypes = columns.Zip(types, (c, t) => new { column = c, type = t });*/
            Doctors doctor = null;
            Patients patient = null;
            PropertyInfo[] properties = null;
            try
            {
                using (HospitalContext hospitalContext = new HospitalContext())
                {
                    if (table.Equals("Doctors"))
                    {
                        doctor = new Doctors();
                        properties = doctor.GetType().GetProperties();
                        var entityType = hospitalContext.Model.FindEntityType(doctor.GetType());
                        for (int i = 0; i < properties.Length; i++)
                        {
                            if (properties[i].Name.Equals(entityType.FindPrimaryKey().Properties.First().Name))
                            {
                                continue;
                            }
                            else
                            {
                                properties[i].SetValue(doctor, GetValuesToInsert(properties[i]));
                            }
                        }
                        //hospitalContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Doctors ON");
                        hospitalContext.Doctors.Add(doctor);
                        hospitalContext.SaveChanges();
                        //hospitalContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Doctors OFF");
                        Console.WriteLine("Inserted");
                    }
                    else if (table.Equals("Patients"))
                    {
                        patient = new Patients();
                        properties = patient.GetType().GetProperties();
                        var entityType = hospitalContext.Model.FindEntityType(patient.GetType());

                        for (int i = 0; i < properties.Length; i++)
                        {
                            if (properties[i].Name.Equals(entityType.FindPrimaryKey().Properties.First().Name))
                            {
                                continue;
                            }
                            else
                            {
                                //Console.WriteLine(properties[i].PropertyType);
                                properties[i].SetValue(patient, GetValuesToInsert(properties[i]));
                                Console.WriteLine(properties[i]);
                            }
                        }
                        /*                        Console.WriteLine(patient.PId + " " + patient.PName + " " + patient.Doctors);*/
                        
                      //  hospitalContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Patients ON");
                        hospitalContext.Patients.Add(patient);
                        hospitalContext.SaveChanges();
                        //hospitalContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Patients OFF");
                        Console.WriteLine("Inserted");
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
            }
            finally
            {
                hospitalContext.Dispose();
            }
        }
        public Doctors GetDoctorId()
        {
            Doctors selectedDoctor = new Doctors();
            try
            {
                using (HospitalContext hospitalDbContext = new HospitalContext())
                {
                    var doctors = hospitalDbContext.Doctors.ToList();
                    //var ids = context.Doctors.Select(d => d.DId).ToList();
                    foreach (var doctor in doctors)
                    {
                        Console.WriteLine(doctor.DId + " "+doctor.DName);
                    }
                    int dId = support.GetNumberInput("");
                    selectedDoctor = hospitalDbContext.Doctors.Find(dId) ;
                    //Console.WriteLine(selectedDoctor.GetType());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //hospitalDbContext.Dispose();
            }
            return selectedDoctor;
        }
        public dynamic GetValuesToInsert(PropertyInfo property)
        {
            dynamic res = null;
            if (property.PropertyType.Name.Equals("String"))
            {
                res = support.GetStringInput($"Enter {property.Name}");
            }
            else if (property.PropertyType.Name.Equals("Int32"))
            {
                res = support.GetNumberInput($"Enter {property.Name}");
            }
            else if (property.PropertyType.Name.Equals("Doctors"))
            {
                Console.WriteLine("Select Doctor");
                res = GetDoctorId();
                
            }
            return res;
        }



        /*public List<string> GetColumnDType(string tableName)
        {
            using (HospitalContext newContext = new HospitalContext())
            {
                var entityType = newContext.Model.GetEntityTypes().FirstOrDefault(t => t.GetTableName() == tableName);
                if (entityType == null)
                {
                    throw new ArgumentException($"Table '{tableName}' not found in the context.");
                }
                var columnTypes = entityType.GetProperties().Select(p => $"{p.ClrType.Name}").ToList();


                return columnTypes;
            }
        }*/

        public void Update(string table)
        {
            try
            {
                using(HospitalContext hospitalContext = new HospitalContext())
                {
                    string tableName = GetTableNameForCRUD();
                    if (tableName.Equals("Doctors"))
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
