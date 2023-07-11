using Entities.Models;

namespace Services.Contracts
{
    public interface IUrunlerService
    {
        IEnumerable<UYUrunler> GetUrunlerList(bool trackChanges);
        UYUrunler? GetUrunById(int id, bool trackChanges);
    }
}
