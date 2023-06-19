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

        public UYUrunler? GetUrunById(int id) => _manager.UYUrunler.GetUrunById(id);

        public IEnumerable<UYUrunler> GetUrunlerList() => _manager.UYUrunler.GetAllUrunList();
    }
}
