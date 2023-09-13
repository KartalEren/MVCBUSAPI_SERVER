using System.Linq.Expressions;

namespace MVCBUSAPI.Repositories.Abstract
{
    public interface IBaseRepo<T> where T : class
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null);

        Task<T> FindById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);

    }


}
