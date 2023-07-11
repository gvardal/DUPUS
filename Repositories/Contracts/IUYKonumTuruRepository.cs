using Entities.Models;

namespace Repositories.Contracts
{
    public interface IUYKonumTuruRepository : IRepositoryBase<UYKonumTuru>
    {
        IQueryable<UYKonumTuru> GetAllKonumTuru(bool trackChanges);
    }
}
