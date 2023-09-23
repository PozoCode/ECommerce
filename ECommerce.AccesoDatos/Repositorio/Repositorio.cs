using ECommerce.AccesoDatos.Data;
using ECommerce.AccesoDatos.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.AccesoDatos.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {

        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;

        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        // Insert into table
        public async Task Add(T entidad)
        {
            await dbSet.AddAsync(entidad);
        }

        // Select * from where id
        public async Task<T> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filters = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null, bool isTracking = true)
        {
            IQueryable<T> query = dbSet;
            if(filters != null)
            {
                query = query.Where(filters);
            }

            if(includeProperties != null)
            {
                foreach (var propertie in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(propertie);
                }
            }

            if(orderBy != null)
            {
                query = orderBy(query);
            }

            if (!isTracking)
            {
                query = query.AsNoTracking();
            }

            return await query.ToListAsync();

        }

        public async Task<T> GetFirst(Expression<Func<T, bool>> filters = null, string includeProperties = null, bool isTracking = true)
        {
            IQueryable<T> query = dbSet;
            if (filters != null)
            {
                query = query.Where(filters);
            }

            if (includeProperties != null)
            {
                foreach (var propertie in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(propertie);
                }
            }
            
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync();
        }

        public void Remove(T entidad)
        {
            dbSet.Remove(entidad);
        }

        public void RemoveRange(IEnumerable<T> entidad)
        {
            dbSet.RemoveRange(entidad);
        }
    }
}
