using Entities.Models;

namespace Repositories.Contracts
{
    public interface IUYKonumRepository : IRepositoryBase<UYKonum>
    {
        IQueryable<UYKonum> GetAllKonumList();
        IQueryable<UYKonum> GetAllKonumByKonumId(byte id);
    }
}
