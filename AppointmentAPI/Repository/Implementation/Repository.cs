using AppointmentAPI.DAL;
using AppointmentAPI.Repository.Interface;

namespace AppointmentAPI.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public AppDBContext _db;

        public Repository(AppDBContext db)
        {
            _db = db;
        }

        public void Delete(long id)
        {
            var entity = _db.Set<T>().Find(id);
            if (entity != null)
            {
                _db.Set<T>().Remove(entity);
            }
        }

        public T Get(long id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
    }
}

