using AppointmentAPI.DAL.Entity.Doctor;

namespace AppointmentAPI.Models.Doctor.DTO
{
    public static class DoctorDTO
    {

        public static  DoctorModelRes DoctorDTOMap(DoctorDetails req)
        {
           return new DoctorModelRes
            {
                CareerStart = req.CareerStart,
                ConsultingFees = req.ConsultingFees,
                Contact = req.Contact,
                DOB = req.DOB,
                Email = req.Email,
                FirstName = req.FirstName,
                Hospital = req.Hospital,
                ImagePath = req.ImagePath,
                LastName = req.LastName,
                Qualification = req.Qualification

            };

        }



        public static DoctorDetails DoctorDTOReqMap(DoctorModelReq req)
        {
            return new DoctorDetails
            {
                CareerStart = req.CareerStart,
                ConsultingFees = req.ConsultingFees,
                Contact = req.Contact,
                DOB = req.DOB,
                Email = req.Email,
                FirstName = req.FirstName,
                Hospital = req.Hospital,              
                LastName = req.LastName,
                Qualification = req.Qualification

            };

        }






    }
}
