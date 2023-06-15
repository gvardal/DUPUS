using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class KonumTuruService : IKonumTuruService
    {
        private readonly IRepositoryManager _manager;

        public KonumTuruService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<UYKonumTuru> GetAllKonumTuru() => _manager.UYKonumTuru.GetAllKonumTuru();
    }
}
