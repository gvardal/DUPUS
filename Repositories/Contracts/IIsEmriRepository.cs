using Entities.Dtos;
using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRepository : IRepositoryBase<UYIsEmri>
    {
        IQueryable<UYIsEmri> GetAllIsEmriList(bool trackChanges);
        IQueryable<UYIsEmri> IsEmriById(int id, bool trackChanges);
        IQueryable<UYIsEmriDurumu> GetAllIsEmriDurumuList();
        UYIsEmriDurumu? GetIsEmriDurumuById(int id);
        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTask();


        // For Blazor Project
        List<WeeklyPlanDto> WeeklyPlanWorkOrders(string konumId);

    }
}
