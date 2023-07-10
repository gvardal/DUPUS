using Entities.Dtos;
using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRepository : IRepositoryBase<UYIsEmri>
    {
        IQueryable<UYIsEmri> GetAllIsEmriList();
        IQueryable<UYIsEmri> IsEmriById(int id);
        IQueryable<UYIsEmriDurumu> GetAllIsEmriDurumuList();
        UYIsEmriDurumu? GetIsEmriDurumuById(int id);
        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTask();
    }
}
