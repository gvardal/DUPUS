using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IIsEmriService
    {
        IEnumerable<UYIsEmri> GetAllIsEmri(bool trackChanges);
        IEnumerable<UYIsEmriDurumu> GetAllIsEmriDurumu();
        UYIsEmriDurumu? GetIsEmriDurumuById(int id);
        UYIsEmri? GetIsEmriById(int id, bool trackChanges);

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTasks();

        // For Blazor Project
        IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId);

    }
}
