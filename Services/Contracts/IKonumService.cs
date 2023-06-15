using Entities.Models;

namespace Services.Contracts
{
    public interface IKonumService
    {
        IEnumerable<UYKonum> GetAllKonumList();
        IEnumerable<UYKonum> GetAllKonumByKonumId(byte id);

    }
}
