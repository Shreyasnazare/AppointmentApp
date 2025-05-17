using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Repository.Interface.Doctor;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AppointmentAPI.Repository.Implementation.Doctor
{
    public class DoctorRepository : Repository<DoctorDetails> , IDoctorRepository
    {

        public DoctorRepository(AppDBContext db) : base(db) { }

        public DoctorDetails GetDoctorDetails(string email)
        {
          return  _db.DoctorDetails.Where(x => x.Email == email).FirstOrDefault();
        }

        DoctorRating IDoctorRepository.GetDoctorRatings(string doctorID)
        {
            try {
                var doctorIdParam = new SqlParameter("@DoctorID", int.Parse(doctorID));

                var result = _db.Set<DoctorRating>()
                    .FromSqlRaw("EXEC GetDoctorRating @DoctorID", doctorIdParam)
                    .AsEnumerable() // Ensures the query is executed
                   .FirstOrDefault(); // Gets the first (or only) record;

                return result;// as DoctorRating;

            }
            catch (Exception) { throw; }
        }

        List<DoctorSpecialisation> IDoctorRepository.GetDoctorSpecialisation(string doctorID)
        {
            try {
                var doctorIdParam = new SqlParameter("@DoctorID", int.Parse(doctorID));

                var result = _db.Set<DoctorSpecialisation>()
                    .FromSqlRaw("EXEC GetDoctorSpecialisation @DoctorID", doctorIdParam)
                    .ToList();

                return result;
            }
            catch (Exception) { throw; }
        }
    }
}
