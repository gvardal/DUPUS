using Entities.Models;

namespace Repositories.Contracts
{
    public interface IUYUrunlerRepository : IRepositoryBase<UYUrunler>
    {
        IQueryable<UYUrunler> GetAllUrunList();
        UYUrunler? GetUrunById(int id);
        string UrunAdi(int id);
    }
}
