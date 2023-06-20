using Entities.Dtos;

namespace DUPUS_WEB.Models
{
    public class GanttCRUDModel
    {
        public List<GanttDataSourceDto>? Added { get; set; }
        public List<GanttDataSourceDto>? Changed { get; set; }
        public List<GanttDataSourceDto>? Deleted { get; set; }
        public GanttDataSourceDto? Value { get; set; }
        public int? Key { get; set; }
        public string? Action { get; set; }
    }
}
