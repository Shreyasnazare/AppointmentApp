using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Customer;
using AppointmentAPI.Models.Doctor;
using AppointmentAPI.Models.Response;

namespace AppointmentAPI.Services.Interface.Doctor
{
    public interface IDoctorService : IService<DoctorDetails>
    {
        DoctorModelRes GetDoctorByEmail(string email);

        Task<Response> InsertDoctorDetail(DoctorModelReq req);

        Task<Response> UpdateDoctorDetail(DoctorModelReq req);

        List<DoctorModelRes> GetAllDoctor();

        DoctorRating GetDoctorRatings(string doctorID);
        List<DoctorSpecialisation> GetDoctorSpecialisation(string doctorID);





    }
}
