
using System.Linq.Expressions;

namespace EArsivPortal.Services.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //Id değerine göre tek kayıt döner
        Task<T> GetByIdAsync(int id);
        //Tüm kayıtları döner
        Task<IEnumerable<T>> GetAllAsync();
        //Belirtilen koşula uyan kayıtları döner
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        //Yeni kayıt ekler
        Task AddAsync(T entity);
        //Kaydı siler
        Task RemoveAsync(T entity);
    }
}
