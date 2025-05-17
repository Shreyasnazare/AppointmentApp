namespace AppointmentAPI.DAL.Entity.Doctor
{
    public class DoctorRating
    {

        public double Rating { get; set; }
        public DateTime Rating_At { get; set; }
        public string Description { get; set; }

        public double AvgRating { get; set; }
    }
}
