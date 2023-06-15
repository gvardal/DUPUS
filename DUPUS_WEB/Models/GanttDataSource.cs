namespace DUPUS_WEB.Models
{
    public partial class ProjectData
    {
        public class GanttDataSource
        {
            public int taskId { get; set; }
            public string? taskName { get; set; }
            public DateTime? startDate { get; set; }
            public DateTime? endDate { get; set; }
            public string? duration { get; set; }
            public int progress { get; set; }
            public string? predecessor { get; set; }
            public int? parentID { get; set; }
            public List<GanttResourceModel>? resources { get; set; }
            public string? customColumn { get; set; }

        }
    }
}
