using Entities.Models;

namespace Repositories.Contracts
{
    public interface IUYKonumRepository : IRepositoryBase<UYKonum>
    {
        IQueryable<UYKonum> GetAllKonumList(bool trackChanges);
        IQueryable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges);
    }
}
