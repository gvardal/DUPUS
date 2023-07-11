using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IKonumService
    {
        IEnumerable<UYKonum> GetAllKonumList(bool trackChanges);
        IEnumerable<UYKonum> GetAllKonumByKonumId(byte id, bool trackChanges);
        IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id, bool trackChanges);        
    }
}
