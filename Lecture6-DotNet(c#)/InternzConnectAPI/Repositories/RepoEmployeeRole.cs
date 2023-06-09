using Azure.Core;
using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace InternzConnectAPI.Repositories
{
    public class RepoEmployeeRole : IRepoEmployeeRole
    {
        private readonly InternzDbContext _context;
        private readonly Random random = new Random();
        public RepoEmployeeRole(InternzDbContext context)
        {
            _context = context;
        }

        List<EmployeeRole> employeeRoles = new();
        EmployeeRole newEmployeeRole = new EmployeeRole();
        EmployeeRoleResponse employeeRoleResponse = new();

        public async Task<EmployeeRoleResponse> GetEmployeeRoles()
        {
            try
            {
                employeeRoles = await _context.EmployeeRoles.Include(x => x.RoleId).Include(y => y.EmployeeId).ToListAsync();
                if (employeeRoles.Count <= 0)
                {
                    AddResponse(true, "No Data Found", employeeRoles);
                    return employeeRoleResponse;
                }
                AddResponse(true, $"{employeeRoles.Count} Records Found", employeeRoles);
                return employeeRoleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employeeRoles);
                return employeeRoleResponse;
            }
        }

        public async Task<EmployeeRoleResponse> GetEmployeeRoleById(string id)
        {
            try
            {
                employeeRoles = await _context.EmployeeRoles.Where(x => (x.ERId ?? "").Equals(id)).ToListAsync();
                if (employeeRoles.Count <= 0)
                {
                    AddResponse(true, $"No EmployeeRole with id : {id} Found", employeeRoles);
                    return employeeRoleResponse;
                }
                AddResponse(true, $"{employeeRoles.Count} records Found", employeeRoles);
                return employeeRoleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employeeRoles);
                return employeeRoleResponse;
            }
        }

        public async Task<EmployeeRoleResponse> PutEmployeeRole(string id, EmployeeRoleRequest request)
        {
            try
            {
                var existingEmployeeRole = await _context.EmployeeRoles.FindAsync(id);
                if (existingEmployeeRole == null)
                {
                    AddResponse(false, $"No EmployeeRole with id: {id}", null);
                    return employeeRoleResponse;
                }
                UpdateEmployeeRole(ref existingEmployeeRole, request);
                employeeRoles.Add(existingEmployeeRole);
                _context.EmployeeRoles.Update(existingEmployeeRole);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Updated", employeeRoles);
                return employeeRoleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employeeRoles);
                return employeeRoleResponse;
            }
        }

        public async Task<EmployeeRoleResponse> DeleteEmployeeRole(string id)
        {
            try
            {
                newEmployeeRole = await _context.EmployeeRoles.FindAsync(id != null ? id : "");
                if (newEmployeeRole == null)
                {
                    AddResponse(true, $"No EmployeeRole with id : {id}", employeeRoles);
                    return employeeRoleResponse;
                }
                await _context.EmployeeRoles.Where(x => (x.ERId != null ? x.ERId : "").Equals(id)).ExecuteDeleteAsync();
                await _context.SaveChangesAsync();
                employeeRoles.Add(newEmployeeRole);
                AddResponse(true, "1 Employee Deleted", employeeRoles);
                return employeeRoleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employeeRoles);
                return employeeRoleResponse;
            }
        }

        public async Task<EmployeeRoleResponse> PostEmployeeRole(EmployeeRoleRequest request)
        {
            try
            {
                var employee = await _context.EmployeeData.FindAsync(request.EmployeeId);
                var role = await _context.Roles.FindAsync(request.RoleId);
                if(employee == null || role == null)
                {
                    AddResponse(true, "RoleId or EmployeeId is Incorrect", employeeRoles);
                    return employeeRoleResponse;
                }
                AddEmployeeRole($"ERID{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}", request);
                employeeRoles.Add(newEmployeeRole);
                await _context.EmployeeRoles.AddAsync(newEmployeeRole);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Added", employeeRoles);
                return employeeRoleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, employeeRoles);
                return employeeRoleResponse;
            }
        }
        public void AddResponse(bool status, string message, List<EmployeeRole> roles)
        {
            employeeRoleResponse = new()
            {
                Status = status,
                Message = message,
                EmployeeRoles = roles,
            };
        }
        public async void AddEmployeeRole(string erId, EmployeeRoleRequest request)
        {
            newEmployeeRole = new()
            {
                ERId = erId,
                RoleId = await _context.Roles.FindAsync(request.RoleId),
                EmployeeId = await _context.EmployeeData.FindAsync(request.EmployeeId)
            };
        }
        private void UpdateEmployeeRole(ref EmployeeRole existingEmployeeRole, EmployeeRoleRequest request)
        {
            existingEmployeeRole.EmployeeId = _context.EmployeeData.Find(request.EmployeeId);
            existingEmployeeRole.RoleId = _context.Roles.Find(request?.RoleId);
        }
    }
}
