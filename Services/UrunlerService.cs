using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class UrunlerService : IUrunlerService
    {
        private readonly IRepositoryManager _manager;

        public UrunlerService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public UYUrunler? GetUrunById(int id, bool trackChanges) => _manager.UYUrunler.GetUrunById(id, trackChanges);

        public IEnumerable<UYUrunler> GetUrunlerList(bool trackChanges) => _manager.UYUrunler.GetAllUrunList(trackChanges);
    }
}
