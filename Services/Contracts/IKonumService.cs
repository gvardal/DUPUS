using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IKonumService
    {
        IEnumerable<UYKonum> GetAllKonumList();
        IEnumerable<UYKonum> GetAllKonumByKonumId(byte id);
        IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id);        
    }
}
