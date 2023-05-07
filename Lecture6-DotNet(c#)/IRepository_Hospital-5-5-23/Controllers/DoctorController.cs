using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IRepository_Hospital_5_5_23.Respositories;
using IRepository_Hospital_5_5_23.Models;

namespace IRepository_Hospital_5_5_23.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IRepositoryHospital _repositoryHospital;
        public DoctorController(IRepositoryHospital repositoryHospital)
        {
            _repositoryHospital = repositoryHospital;
        }
        [HttpPost]
        public Task<ActionResult<string>> PostDoc(DoctorDummy doc)
        {
            return _repositoryHospital.AddDoctor(doc);
        }
        [HttpDelete("{id}")]
        public Task<ActionResult<string>> DeleteDoc(int id)
        {
            return _repositoryHospital.DeleteDoctorDetails(id);
        }
        [HttpGet]
        public Task<IEnumerable<Doctor>> GetDoc()
        {
            return _repositoryHospital.GetDoctorDetails();
        }
        [HttpPut("{id}")]
        public Task<ActionResult<string>> PutDoc(int id, DoctorDummy doc)
        {
            return _repositoryHospital.UpdateDoctorDetails(id, doc);
        }
    }

}
