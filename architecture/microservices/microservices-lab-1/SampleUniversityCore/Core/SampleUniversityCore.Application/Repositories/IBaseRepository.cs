using System.Linq.Expressions;

namespace SampleUniversityCore.Application.Repositories;

public interface IBaseRepository<T>
{
    Task<T?> Get(int id);
    Task<int> Count(Expression<Func<T, bool>> filter);
    Task<int> Count();
    Task<IEnumerable<T>> List(int resultsSize = 10, int offset = 0);
    Task<IEnumerable<T>> List();
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<IEnumerable<T>> Search(Expression<Func<T, bool>> filter, int resultsSize = 10, int offset = 0);
    Task<IEnumerable<T>> Search(Expression<Func<T, bool>> filter);
    Task<bool> Exist(Expression<Func<T, bool>> filter);
    Task<T?> Find(Expression<Func<T, bool>> filter);
}
