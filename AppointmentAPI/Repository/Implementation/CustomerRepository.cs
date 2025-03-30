using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity;
using AppointmentAPI.Repository.Interface;

namespace AppointmentAPI.Repository.Implementation
{
    public class CustomerRepository : Repository<CustomerDetails>,ICustomerRepository
    {

      

        public CustomerRepository(AppDBContext db) : base(db) { }

        public CustomerDetails GetCustomerByEmail(string email)
        {
           return _db.Customer.Where(x=>x.Email.ToUpper() == email.ToUpper()).FirstOrDefault();
          
        }
    }
}
