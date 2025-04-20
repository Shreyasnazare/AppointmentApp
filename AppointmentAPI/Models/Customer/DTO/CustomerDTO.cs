using AppointmentAPI.DAL.Entity.Customer;

namespace AppointmentAPI.Models.Customer.Customer.DTO
{
    public static class CustomerDTO
    {
        public static CustomerModel CustomerDTOMap(CustomerDetails oReq)
        {
            try
            {
                CustomerModel res = new CustomerModel();
                res.Address = oReq.Address;
                res.LastName = oReq.LastName;
                res.FirstName = oReq.FirstName;

                res.Email = oReq.Email;
                res.Contact = oReq.Contact;
                //res.CustomerID = oReq.CustomerID;
                return res;

            }
            catch (Exception e)
            {
                throw;
            }
        }


        public static CustomerDetails CustomerDTOMapReverse(CustomerModel oReq , CustomerDetails res = null)
        {
            try
            {
                //CustomerDetails res = new CustomerDetails();
                if(res == null)
                    res = new CustomerDetails();

                res.Address = oReq.Address;
                res.LastName = oReq.LastName;
                res.FirstName = oReq.FirstName;

                res.Email = oReq.Email;
                res.Contact = oReq.Contact;
                res.DOB = Convert.ToDateTime(oReq.DOB);
                //res.CustomerID = oReq.CustomerID;
                return res;

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
