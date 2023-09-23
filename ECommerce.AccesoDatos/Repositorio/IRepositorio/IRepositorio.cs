using System.Linq.Expressions;

namespace ECommerce.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        //Métodos que usaremos en el proyecto

        Task<T> Get(int id);

        Task<IEnumerable<T>> GetAll(
            Expression<Func<T, bool>> filters = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null,
            bool isTracking = true
            );

        Task<T> GetFirst(
            Expression<Func<T, bool>> filters = null,
            string includeProperties = null,
            bool isTracking = true
            );

        Task Add(T entidad);

        void Remove(T entidad);

        void RemoveRange(IEnumerable<T> entidad);
    }
}
