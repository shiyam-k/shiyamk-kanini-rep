using IRepository_Hospital_5_5_23.Models;
using IRepository_Hospital_5_5_23.Respositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRepository_Hospital_5_5_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IRepositoryHospital _repositoryHospital;
        public PatientController(IRepositoryHospital repositoryHospital)
        {
            _repositoryHospital = repositoryHospital;
        }
        [HttpPost]
        public Task<ActionResult<string>> PostPat(PatientDummy doc)
        {
            return _repositoryHospital.AddPatient(doc);
        }
        [HttpDelete("{id}")]
        public Task<ActionResult<string>> DeletePatc(int id)
        {
            return _repositoryHospital.DeletePatient(id);
        }
        [HttpGet]
        public Task<IEnumerable<Patient>> GetPat()
        {
            return _repositoryHospital.GetPatientDetails();
        }
        [HttpPut("{id}")]
        public Task<ActionResult<string>> PutPat(int id, PatientDummy pat)
        {
            return _repositoryHospital.UpdatePatient(id, pat);
        }
    }
}
