namespace AppointmentAPI.Services.Interface
{
    public interface IService<T> where T : class
    {

        IEnumerable<T> GetAll();

        T Get(long id);

        void Update(T entity);

        void Delete(long id);

        int SaveChanges();

        void Insert(T Entity);
    }
}
