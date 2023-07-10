namespace Entities.Dtos
{
    public class GanttDataSource
    {
        public int taskId { get; set; }
        public string taskName { get; set; } = string.Empty;
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int duration { get; set; }
        public string? durationUnit { get; set; } = "minutes";
        public decimal? progress { get; set; }
        public string? predecessor { get; set; }
        public int? parentID { get; set; }
        public string? work { get; set; }
        public List<ResourceData>? resources { get; set; }
    }

}
