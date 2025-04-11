using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Repository.Interface.Doctor;

namespace AppointmentAPI.Repository.Implementation.Doctor
{
    public class DoctorRepository : Repository<DoctorDetails> , IDoctorRepository
    {

        public DoctorRepository(AppDBContext db) : base(db) { }

        public DoctorDetails GetDoctorDetails(string email)
        {
          return  _db.DoctorDetails.Where(x => x.Email == email).FirstOrDefault();
        }

       
    }
}
