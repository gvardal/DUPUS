using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class KonumService : IKonumService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public KonumService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public IEnumerable<GanttResourceGroupDto> GanttResourceGroup(byte id)
        {
            var konumList = _manager.UYKonum.GetAllKonumByKonumId(id);
            var resourceGroup = _mapper.Map<List<GanttResourceGroupDto>>(konumList);
            return resourceGroup;
        }

        public IEnumerable<UYKonum> GetAllKonumByKonumId(byte id) => _manager.UYKonum.GetAllKonumByKonumId(id);

        public IEnumerable<UYKonum> GetAllKonumList() => _manager.UYKonum.GetAllKonumList();
    }
}
