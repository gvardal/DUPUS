using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IIsEmriService
    {
        IEnumerable<UYIsEmri> GetAllIsEmri();
        IEnumerable<UYIsEmriDurumu> GetAllIsEmriDurumu();
        UYIsEmriDurumu? GetIsEmriDurumuById(int id);
        UYIsEmri? GetIsEmriById(int id);

        List<TaskData> GanttTasks();
        List<GanttMainTaskDto> GanttMainTasks();

        // For Blazor Project
        IEnumerable<WeeklyPlanDto> GetWeeklyPlanWorkOrders(string konumId);

    }
}
