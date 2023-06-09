using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;

namespace InternzConnectAPI.Repositories
{
    public class RepoEmployees : IRepoEmployees
    {
        private readonly InternzDbContext _context;
        private readonly Random random = new Random();
        public RepoEmployees(InternzDbContext context) 
        {
            _context = context;
        }

        List<EmployeeData> employees = new();
        EmployeeData newEmployee = new EmployeeData();
        EmployeeResponse employeeResponse = new();
        public async Task<EmployeeResponse> DeleteEmployee(string id)
        {
            try
            {
                newEmployee = await _context.EmployeeData.FindAsync(id != null ? id : "");
                if (newEmployee == null)
                {
                    AddResponse(true, $"No Employee with id : {id}", employees);
                    return employeeResponse;
                }
                await _context.EmployeeData.Where(x => (x.EmployeeId != null ? x.EmployeeId : "").Equals(id)).ExecuteDeleteAsync();
                await _context.SaveChangesAsync();
                employees.Add(newEmployee);
                AddResponse(true, "1 Employee Deleted", employees);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employees);
                return employeeResponse;
            }
        }

        public async Task<EmployeeResponse> PutEmployee(string id, EmployeeRequest employee)
        {
            try
            {
                var existingEmployee = await _context.EmployeeData.FindAsync(id);
                if (existingEmployee == null)
                {
                    AddResponse(false, $"No Employee with id: {id}", null);
                    return employeeResponse;
                }
                UpdateEmployee(existingEmployee, employee);
                employees.Add(existingEmployee);
                _context.EmployeeData.Update(existingEmployee);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Updated", employees);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.StackTrace, employees);
                return employeeResponse;
            }
        }

        /*GET ALL  ROOMS*/
        public async Task<EmployeeResponse> GetEmployees()
        {
            try
            {
                employees = await _context.EmployeeData.ToListAsync();
                if (employees.Count <= 0)
                {
                    AddResponse(true, "No Data Found", employees);
                    return employeeResponse;
                }
                AddResponse(true, $"{employees.Count} Records Found", employees);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employees);
                return employeeResponse;
            }
        }
        /*GET ROOM BY ID*/
        public async Task<EmployeeResponse> GetEmployeeById(string id)
        {
            try
            {
                employees = await _context.EmployeeData.Where(x => (x.EmployeeId ?? "").Equals(id)).Include(y => y.EmployeeRoles).Include(z => z.LoginLogs).ToListAsync();
                if (employees.Count <= 0)
                {
                    AddResponse(true, "No Employee Found", employees);
                    return employeeResponse;
                }
                AddResponse(true, $"{employees.Count} records Found", employees);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employees);
                return employeeResponse;
            }
        }
        /*POST ROOM*/
        public async Task<EmployeeResponse> PostEmployee(EmployeeRequest employee)
        {
            try
            {
                
                AddEmployee($"EID{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}", employee);
                employees.Add(newEmployee);
                await _context.EmployeeData.AddAsync(newEmployee);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Added", employees);
                return employeeResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employees);
                return employeeResponse;
            }
        }
        public void AddResponse(bool status, string message, List<EmployeeData> employees)
        {
            employeeResponse = new()
            {
                Status = status,
                Message = message,
                EmployeeRequest = employees,
            };
        }
        public void AddEmployee(string employeeId, EmployeeRequest employee)
        {
            byte[] PasswordHash;
            byte[] PasswordKey;
            CreatePasswordHash(employee.Password ?? "", out PasswordHash, out PasswordKey);
            newEmployee = new()
            {
                EmployeeId = employeeId,
                EmployeeFirstName = employee.EmployeeFirstName,
                EmployeeLastName = employee.EmployeeLastName,
                EmployeeDOB= employee.EmployeeDOB,
                EmployeeDOJ= employee.EmployeeDOJ,
                Course = employee.Course,
                Stream = employee.Stream,
                Email = employee.Email,
                EmployeePasswordHash= PasswordHash,
                EmployeePasswordKey= PasswordKey
                
            };
        }
        private void UpdateEmployee(EmployeeData existingEmployee, EmployeeRequest employee)
        {
            existingEmployee.EmployeeFirstName = employee.EmployeeFirstName;
            existingEmployee.EmployeeLastName = employee.EmployeeLastName;
            existingEmployee.EmployeeDOB = employee.EmployeeDOB;
            existingEmployee.EmployeeDOJ = employee.EmployeeDOJ;
            existingEmployee.Course = employee.Course;
            existingEmployee.Stream = employee.Stream;
            existingEmployee.Email = employee.Email;

            // You may also update other properties accordingly
        }
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordKey)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordKey = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {                        
                        return false; 
                    }
                }

                return true; 
            }
        }
    }
}
