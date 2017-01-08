using WebApplication1.InterfaceBLL;
using WebApplication1.Interface;

namespace WebApplication1.BLL
{
    public abstract class BaseService<T>: IBaseService<T> where T: class
    {
        protected IBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(IBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        public T Add(T entity) { return CurrentRepository.Add(entity); }

        public bool Update(T entity) { return CurrentRepository.Update(entity); }

        public bool Delete(T entity) { return CurrentRepository.Delete(entity); }
    }
}
