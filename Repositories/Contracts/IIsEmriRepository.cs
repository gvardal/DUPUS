using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRepository : IRepositoryBase<UYIsEmri>
    {
        IQueryable<UYIsEmri> GetAllIsEmriList();
        IQueryable<UYIsEmri> IsEmriById(long id);
    }
}
