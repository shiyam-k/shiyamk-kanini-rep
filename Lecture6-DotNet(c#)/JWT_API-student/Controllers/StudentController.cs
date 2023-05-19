using JWT_API_student.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWT_API_student.Auth;
using System.Data;
using System.Numerics;

namespace ProAPI.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _context;
        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            return _context.Students.ToList();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Student>> GetById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Student>> Delete(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }

            var emp = await _context.Students.FindAsync(id);
            /* if(emp != null)
             {
                 return NotFound(emp);
             }*/

            _context.Students.Remove(emp);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student doctor)
        {
            var docObject = new Student()
            {
                sname = doctor.sname,
                specialization = doctor.specialization

            };
            _context.Students.AddAsync(docObject);
            await _context.SaveChangesAsync();
            return Ok(docObject);
        }
    }
}