using WebApiEFAssDay1.Models;
using System.Linq.Expressions;

namespace WebApiEFAssDay1.Repositories.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity<int>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        T? Get(Expression<Func<T, bool>> predicate);
        T Create(T entity);
        T Update(T entity);
        bool Delete(T entity);
        int SaveChanges();
    }
}