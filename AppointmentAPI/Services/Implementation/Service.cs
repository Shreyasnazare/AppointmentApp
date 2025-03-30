using AppointmentAPI.Repository.Interface;
using AppointmentAPI.Services.Interface;

namespace AppointmentAPI.Services.Implementation
{
    public class Service<T> : IService<T> where T : class
    {
        public IRepository<T> _repo;  

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }


        public void Insert(T Entity) { 
        _repo.Insert(Entity);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public T Get(int id)
        {
          return _repo.Get(id);
        }

        public IEnumerable<T> GetAll()
        {
          return _repo.GetAll();
        }

        public int SaveChanges()
        {
           return _repo.SaveChanges();
        }

        public void Update(T entity)
        {
            _repo.Update(entity);
        }
    }
}
