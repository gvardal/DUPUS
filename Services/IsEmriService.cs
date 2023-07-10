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

        public List<TaskData> GanttTasks()
        {
            var result = _manager.IsEmri.GanttTasks();
            return result;
        }

        public List<GanttMainTaskDto> GanttMainTasks()
        {
            var result = _manager.IsEmri.GanttMainTask();
            return result;
        }

        public IEnumerable<UYIsEmri> GetAllIsEmri() => _manager.IsEmri.GetAllIsEmriList().Take(5);

        public IEnumerable<UYIsEmriDurumu> GetAllIsEmriDurumu() => _manager.IsEmri.GetAllIsEmriDurumuList();

        public UYIsEmri? GetIsEmriById(int id) => _manager.IsEmri.IsEmriById(id).SingleOrDefault();

        public UYIsEmriDurumu? GetIsEmriDurumuById(int id) => _manager.IsEmri.GetIsEmriDurumuById(id);

        public IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId) => _manager.IsEmri.WeeklyPlanWorkOrders(konumId);
    }
}
