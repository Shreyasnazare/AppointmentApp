using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;

namespace AppointmentAPI.Repository.Interface.Doctor
{
    public interface IDoctorSlotsRepository : IRepository<DoctorSlots> 
    {
        IEnumerable<DoctorSlotsTiming> GetDoctorSlots(string doctorId);
    }
}
