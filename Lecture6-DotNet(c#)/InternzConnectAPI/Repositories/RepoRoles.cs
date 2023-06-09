using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using Microsoft.EntityFrameworkCore;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace InternzConnectAPI.Repositories
{
    public class RepoRoles : IRepoRoles
    {
        private readonly InternzDbContext _context;
        private readonly Random random = new Random();
        public RepoRoles(InternzDbContext context)
        {
            _context = context;
        }

        List<Roles> roles = new();
        Roles newRole= new Roles();
        RolesResponse roleResponse = new();
        public async Task<RolesResponse> DeleteRole(string id)
        {
            try
            {
                newRole= await _context.Roles.FindAsync(id != null ? id : "");
                if (newRole == null)
                {
                    AddResponse(true, $"No Employee with id : {id}", roles);
                    return roleResponse;
                }
                await _context.Roles.Where(x => (x.RoleId != null ? x.RoleId : "").Equals(id)).ExecuteDeleteAsync();
                await _context.SaveChangesAsync();
                roles.Add(newRole);
                AddResponse(true, "1 Employee Deleted", roles);
                return roleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, roles);
                return roleResponse;
            }
        }

        public async Task<RolesResponse> PutRole(string id, string role)
        {
            try
            {
                var existingRole = await _context.Roles.FindAsync(id);
                if (existingRole == null)
                {
                    AddResponse(false, $"No Employee with id: {id}", null);
                    return roleResponse;
                }
                UpdateRole(ref existingRole, role);
                roles.Add(existingRole);
                _context.Roles.Update(existingRole);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Updated", roles);
                return roleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, roles);
                return roleResponse;
            }
        }

        /*GET ALL  ROOMS*/
        public async Task<RolesResponse> GetRoles()
        {
            try
            {
                roles = await _context.Roles.ToListAsync();
                if (roles.Count <= 0)
                {
                    AddResponse(true, "No Data Found", roles);
                    return roleResponse;
                }
                AddResponse(true, $"{roles.Count} Records Found", roles);
                return roleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, roles);
                return roleResponse;
            }
        }
        /*GET ROOM BY ID*/
        public async Task<RolesResponse> GetRoleById(string id)
        {
            try
            {
                roles = await _context.Roles.Where(x => (x.RoleId ?? "").Equals(id)).ToListAsync();
                if (roles.Count <= 0)
                {
                    AddResponse(true, "No Employee Found", roles);
                    return roleResponse;
                }
                AddResponse(true, $"{roles.Count} records Found", roles);
                return roleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, roles);
                return roleResponse;
            }
        }
        /*POST ROOM*/
        public async Task<RolesResponse> PostRole(string role)
        {
            try
            {

                AddEmployee($"ROLEID{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}", role);
                roles.Add(newRole);
                await _context.Roles.AddAsync(newRole);
                await _context.SaveChangesAsync();
                AddResponse(true, "1 Record Added", roles);
                return roleResponse;
            }
            catch (Exception ex)
            {
                AddResponse(false, ex.Message, roles);
                return roleResponse;
            }
        }
        public void AddResponse(bool status, string message, List<Roles> roles)
        {
            roleResponse = new()
            {
                Status = status,
                Message = message,
                Roles = roles,
            };
        }
        public void AddEmployee(string roleId, string role)
        {
            newRole = new()
            {
                RoleId = roleId,
                RoleName = role

            };
        }
        private void UpdateRole(ref Roles existingRole, string role)
        {
            existingRole.RoleName = role;
        }
        
    }
}
