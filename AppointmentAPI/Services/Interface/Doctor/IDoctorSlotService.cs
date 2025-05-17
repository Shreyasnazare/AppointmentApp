using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;
using AppointmentAPI.Services.Implementation;

namespace AppointmentAPI.Services.Interface.Doctor
{
    public interface IDoctorSlotService : IService<DoctorSlots>
    {

        List<DoctorSlotsTiming> GetDoctorSlots(string doctorId);
    }
}
