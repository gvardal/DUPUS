using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext _context;

        protected RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll() => _context.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression) => _context.Set<T>().Where(expression);

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity) => _context.Update(entity);
    }
}
