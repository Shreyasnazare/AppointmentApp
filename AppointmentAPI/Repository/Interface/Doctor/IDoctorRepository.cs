using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;

namespace AppointmentAPI.Repository.Interface.Doctor
{
    public interface IDoctorRepository : IRepository<DoctorDetails>
    {

        DoctorDetails GetDoctorDetails(string email);

        DoctorRating GetDoctorRatings(string doctorID);
        List<DoctorSpecialisation> GetDoctorSpecialisation(string doctorID);



    }
}
