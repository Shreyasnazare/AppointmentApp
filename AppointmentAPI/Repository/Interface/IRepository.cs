namespace AppointmentAPI.Repository.Interface
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Update(T entity);

        void Insert(T entity);

        void Delete(int id);

        int SaveChanges();

    }
}
