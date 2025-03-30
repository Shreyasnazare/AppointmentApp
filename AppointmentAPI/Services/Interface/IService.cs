namespace AppointmentAPI.Services.Interface
{
    public interface IService<T> where T : class
    {

        IEnumerable<T> GetAll();

        T Get(int id);

        void Update(T entity);

        void Delete(int id);

        int SaveChanges();

        void Insert(T Entity);
    }
}
