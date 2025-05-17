using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;
using AppointmentAPI.Models.Doctor.DTO;
using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Repository.Interface.Doctor;
using AppointmentAPI.Services.Interface.Doctor;

namespace AppointmentAPI.Services.Implementation.Doctor
{
    public class DoctorSlotsService : Service<DoctorSlots>, IDoctorSlotService
    {

        IDoctorSlotsRepository _repo;

        public DoctorSlotsService(IDoctorSlotsRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public List<DoctorSlotsTiming> GetDoctorSlots(string doctorId)
        {
            try
            {

                //  return _repo.GetAll()
                //.Select(DoctorDTO.DoctorDTOMap)  // ****** Imp this will call the  DoctorDTO.DoctorDTOMap one by one for each record
                //.ToList();
               
                return _repo.GetDoctorSlots(doctorId).ToList();   // ****** Imp this will call the  DoctorSlotsDTO.DoctorSlotsToModel one by one for each record


            }
            catch
            {
                throw;
            }

        }
    }
}
