using Design_Pattern_10_5_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Design_Pattern_10_5_23.Repositories
{
    public class RepositoryDI : IRepositoryDI
    {
        private readonly ApplicationDbContext _context;
        public RepositoryDI(ApplicationDbContext context)
        {
            _context = context;
        }

        public string InsertRoles(Roles r)
        {
           
            _context.Roles.Add(r);
            _context.SaveChanges();
            return "Added";
        }

        public int GetRoleCount()
        {
            return _context.Roles.Count();
        }

        
    }
}