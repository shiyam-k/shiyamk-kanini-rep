using IRepository_Hospital_5_5_23.Models;
using Microsoft.AspNetCore.Mvc;

namespace IRepository_Hospital_5_5_23.Respositories
{
    public interface IRepositoryHospital
    {
        Task<IEnumerable<Doctor>> GetDoctorDetails();
        Task<ActionResult<string>> AddDoctor(DoctorDummy doc);
        Task<ActionResult<string>> UpdateDoctorDetails(int id, DoctorDummy doc);
        Task<ActionResult<string>> DeleteDoctorDetails(int id);

        Task<IEnumerable<Patient>> GetPatientDetails();
        Task<ActionResult<string>> AddPatient(PatientDummy p);
        Task<ActionResult<string>> UpdatePatient(int id, PatientDummy p);
        Task<ActionResult<string>> DeletePatient(int id);

    }
}
