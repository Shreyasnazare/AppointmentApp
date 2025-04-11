namespace AppointmentAPI.Models.Response
{
    public class Response
    {
        public string message { get; set; }
        public Boolean success { get; set; }
    }

    public class ResponseV2<T>
    {
        public string message { get; set; }
        public Boolean success { get; set; }
        public T Data { get; set; }
    }
}
