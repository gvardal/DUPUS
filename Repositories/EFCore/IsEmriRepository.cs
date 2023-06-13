using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class IsEmriRepository : RepositoryBase<UYIsEmri>, IIsEmriRepository
    {
        public IsEmriRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYIsEmri> GetAllIsEmriList() => GetAll();

        public IQueryable<UYIsEmri> IsEmriById(long id) => GetByCondition(x => x.IsEmriID.Equals(id));
    }
}
