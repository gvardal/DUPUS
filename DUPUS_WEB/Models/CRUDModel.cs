namespace DUPUS_WEB.Models
{
    public class CRUDModel
    {
        public List<GanttDataSource>? Added { get; set; }
        public List<GanttDataSource>? Changed { get; set; }
        public List<GanttDataSource>? Deleted { get; set; }
        public object? Key { get; set; }
        public string? Action { get; set; }
        public string? Table { get; set; }
    }
}
