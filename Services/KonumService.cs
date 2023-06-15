using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class KonumService : IKonumService
    {
        private readonly IRepositoryManager _manager;

        public KonumService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<UYKonum> GetAllKonumByKonumId(byte id) => _manager.UYKonum.GetAllKonumByKonumId(id);

        public IEnumerable<UYKonum> GetAllKonumList() => _manager.UYKonum.GetAllKonumList();
    }
}
