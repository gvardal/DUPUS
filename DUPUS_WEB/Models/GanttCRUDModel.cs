using static DUPUS_WEB.Models.ProjectData;

namespace DUPUS_WEB.Models
{
    public class GanttCRUDModel
    {
        public List<GanttDataSource>? Added { get; set; }
        public List<GanttDataSource>? Changed { get; set; }
        public List<GanttDataSource>? Deleted { get; set; }
        public GanttDataSource? Value { get; set; }
        public int? Key { get; set; }
        public string? Action { get; set; }
    }
}
