using IRepository_Hospital_5_5_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IRepository_Hospital_5_5_23.Respositories
{
    public class RepositoryHospital : IRepositoryHospital
    {
        private readonly HospitalContext hospitalContext;
        public RepositoryHospital(HospitalContext hospitalContext)
        {
            this.hospitalContext = hospitalContext;
        }
        public async Task<ActionResult<string>> AddDoctor(DoctorDummy doc)
        {
            Doctor dos = new Doctor();
            dos.Dname = doc.doctorname;
            await hospitalContext.AddAsync(dos);
            await hospitalContext.SaveChangesAsync();
            return "Added";
        }

        public async Task<ActionResult<string>> DeleteDoctorDetails(int id)
        {
            Doctor doc = await hospitalContext.Doctors.FindAsync(id);
            if(doc == null)
            {
                return "Not Found";
            }
            hospitalContext.Doctors.Remove(doc);
            await hospitalContext.SaveChangesAsync();
            return "Deleted";
        }

        public async Task<IEnumerable<Doctor>> GetDoctorDetails()
        {

            return hospitalContext.Doctors.Include(x => x.Patients).ToList();
        }

        public async Task<ActionResult<string>> UpdateDoctorDetails(int id, DoctorDummy doc)
        {
            Doctor updateDoctor = await hospitalContext.Doctors.FindAsync(id);
            if(updateDoctor == null)
            {
                return "Not Found";
            }
            updateDoctor.Dname = doc.doctorname;
            await hospitalContext.SaveChangesAsync();
            return "Updated";
        }
        public async Task<ActionResult<string>> AddPatient(PatientDummy p)
        {
            Patient pat = new Patient();
            pat.Pname = p.Pname;
            Doctor doc = hospitalContext.Doctors.Find(p.DoctorsDid);
            pat.DoctorsD = doc;
            await hospitalContext.AddAsync(pat);
            await hospitalContext.SaveChangesAsync();
            return "Added";
        }

        public async Task<ActionResult<string>> DeletePatient(int id)
        {
            Patient pat = await hospitalContext.Patients.FindAsync(id);
            if (pat == null)
            {
                return "Not Found";
            }
            hospitalContext.Patients.Remove(pat);
            await hospitalContext.SaveChangesAsync();
            return "Deleted";
        }

        public async Task<IEnumerable<Patient>> GetPatientDetails()
        {

            return hospitalContext.Patients.Include(x => x.DoctorsD).ToList();
        }

        public async Task<ActionResult<string>> UpdatePatient(int id, PatientDummy doc)
        {
            Patient updatePatient = await hospitalContext.Patients.FindAsync(id);
            if (updatePatient == null)
            {
                return "Not Found";
            }
            updatePatient.Pname = updatePatient.Pname;
            await hospitalContext.SaveChangesAsync();
            return "Updated";
        }
    }
}
