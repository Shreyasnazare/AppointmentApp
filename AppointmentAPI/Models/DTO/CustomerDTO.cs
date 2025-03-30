using AppointmentAPI.DAL.Entity;

namespace AppointmentAPI.Models.DTO
{
    public static class CustomerDTO
    {
        public static Customer CustomerDTOMap(DAL.Entity.CustomerDetails oReq)
        {
            try
            {
                Customer res = new Customer();
                res.Address = oReq.Address;
                res.LastName = oReq.LastName;
                res.FirstName = oReq.FirstName;
                res.CustomerID = oReq.CustomerID;
                res.Email = oReq.Email;
                res.Contact = oReq.Contact;
                res.CustomerID = oReq.CustomerID;
                return res;

            }
            catch (Exception e)
            {
                throw;
            }
        }


        public static DAL.Entity.CustomerDetails CustomerDTOMapReverse(Customer oReq)
        {
            try
            {
                CustomerDetails res = new CustomerDetails();
                res.Address = oReq.Address;
                res.LastName = oReq.LastName;
                res.FirstName = oReq.FirstName;
                res.CustomerID = oReq.CustomerID;
                res.Email = oReq.Email;
                res.Contact = oReq.Contact;
                res.CustomerID = oReq.CustomerID;
                return res;

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
