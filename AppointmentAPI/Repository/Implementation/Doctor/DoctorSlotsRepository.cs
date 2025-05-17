using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity.Doctor;
using AppointmentAPI.Models.Doctor;
using AppointmentAPI.Repository.Interface.Doctor;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace AppointmentAPI.Repository.Implementation.Doctor
{
    public class DoctorSlotsRepository : Repository<DoctorSlots>, IDoctorSlotsRepository
    {

        public DoctorSlotsRepository(AppDBContext db) : base(db) { }
        public IEnumerable<DoctorSlotsTiming> GetDoctorSlots(string doctorId)
        {
            try
            {
                //return _db.DoctorSlots.Where(x => x.DoctorID == long.Parse(doctorId));


                var result = (from doctorslots in _db.DoctorSlots
                              join timeslot in _db.TimeSlots
                              on doctorslots.TimeSlotID equals timeslot.TimeSlotID
                              where doctorslots.DoctorID == long.Parse(doctorId)
                              select new DoctorSlotsTiming
                              {
                                  DoctorID = doctorslots.DoctorID.ToString(),
                                  TimeSlotID = doctorslots.TimeSlotID.ToString(),
                                  SlotFilled = doctorslots.SlotFilled.ToString(),
                                  SlotCapacity = doctorslots.SlotCapacity.ToString(),
                                  SlotStart = timeslot.SlotStart,
                                  SlotEnd = timeslot.SlotEnd,
                                
                              }).ToList();

                return result;
            }
            catch
            {
                throw;
            }

        }
    }
}
