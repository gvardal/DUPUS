using Entities.Models;

namespace Services.Contracts
{
    public interface IKonumTuruService
    {
        IEnumerable<UYKonumTuru> GetAllKonumTuru();
    }
}
