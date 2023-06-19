using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class IsEmriService : IIsEmriService
    {
        private readonly IRepositoryManager _manager;

        public IsEmriService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<GanttDataSourceDto> GanttDataSource()
        {
            var result = _manager.IsEmri.GanttDataSource();
            return result;
        }

        public IEnumerable<UYIsEmri> GetAllIsEmri() => _manager.IsEmri.GetAllIsEmriList().Take(5);

        public IEnumerable<UYIsEmriDurumu> GetAllIsEmriDurumu() => _manager.IsEmri.GetAllIsEmriDurumuList();

        public UYIsEmri? GetIsEmriById(int id) => _manager.IsEmri.IsEmriById(id).SingleOrDefault();

        public UYIsEmriDurumu? GetIsEmriDurumuById(int id) => _manager.IsEmri.GetIsEmriDurumuById(id);
    }
}
