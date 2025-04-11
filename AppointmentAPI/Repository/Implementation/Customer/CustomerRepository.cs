using AppointmentAPI.DAL;
using AppointmentAPI.DAL.Entity.Customer;
using AppointmentAPI.Repository.Interface.Customer;

namespace AppointmentAPI.Repository.Implementation.Customer
{
    public class CustomerRepository : Repository<CustomerDetails>, ICustomerRepository
    {



        public CustomerRepository(AppDBContext db) : base(db) { }

        public CustomerDetails GetCustomerByEmail(string email)
        {

            return _db.Customer.Where(x => x.Email == email).FirstOrDefault();

            //return _db.Customer
            //    .FirstOrDefault(x =>
            //        x.Email != null &&  
            //        string.Equals(x.Email.Trim(), email.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
