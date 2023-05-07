using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Web_API_Code_First__02_05_23.Models;

namespace Web_API_Code_First__02_05_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientEmptyController : ControllerBase
    {
        private readonly HospitalDbContext patientControllerContext;
        public PatientEmptyController(HospitalDbContext context)
        {
            patientControllerContext = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatient()
        {
            if(patientControllerContext.Patients == null)
            {
                return NotFound();
            }
            var dbStudents = await patientControllerContext.Patients
                                     .Include(i => i.DoctorsD)
                                     .ToListAsync();
            return dbStudents.ToList();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatients(int id) 
        {
            if(patientControllerContext.Patients == null)
            {
                return NotFound();
            }
            var requestedPatient = await patientControllerContext.Patients.FindAsync(id);
            if(requestedPatient == null)
            {
                return NotFound();
            }
            return requestedPatient;
        }

        [HttpPost]
        public async Task<ActionResult<string>> PostPatient(PatientPost patient)
        {
            if(patientControllerContext== null)
            {
                return NotFound();
            }
            Doctor assignedDoctor = await patientControllerContext.Doctors.FindAsync(patient.Did);
            if(assignedDoctor == null)
            {
                return NotFound();
            }
            else
            {
                Patient pat = new Patient
                {
                    Pname = patient.pname,
                    DoctorsD = assignedDoctor

                };
                //assignedDoctor.Patients.Add(pat);
                patientControllerContext.Doctors.Update(assignedDoctor);
                await patientControllerContext.SaveChangesAsync();
                await patientControllerContext.AddAsync(pat);
                await patientControllerContext.SaveChangesAsync();
                return Ok("Added");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PutPatients(int id, Patient patient)
        {
            if(patientControllerContext.Patients == null)
            {
                return BadRequest();

            }
            //patientControllerContext.Entry(patient).State = EntityState.Modified;
            if(patient != null)
            {
                Patient pat = await patientControllerContext.Patients.FindAsync(id);
                pat.Pname = patient.Pname;
                //pat.DoctorsD.Did = patient.DoctorsD.Did;
                await patientControllerContext.SaveChangesAsync();
                return Ok("Updated");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<String>> DeletePatient(int id)
        {
            if (patientControllerContext.Patients == null)
            {
                return BadRequest();
            }
            var patient = patientControllerContext.Patients.Find(id);
            if (patient == null)
            {
                return BadRequest();
            }
            patientControllerContext.Patients.Remove(patient);
            await patientControllerContext.SaveChangesAsync();
            return Ok("Deleted");
        }
    }
}
