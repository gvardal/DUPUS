namespace Entities.Dtos
{
    public class GanttDataSource
    {
        public int taskId { get; set; }
        public string? taskName { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int? duration { get; set; }
        public string? durationUnit { get; set; } = "minutes";
        public decimal? progress { get; set; }
        public string? predecessor { get; set; }
        public int? parentID { get; set; }
        public List<ResourceModel>? resources { get; set; }
    }

    public class ResourceModel
    {
        public int resourceId { get; set; }
        public string? resourceName { get; set; }
        public string? resourceGroup { get; set; }
        public int? resourceUnit { get; set; }
        public int? ActivityId { get; set; }
    }

    public class IndicatorsModelDto
    {
        public string? Date { get; set; }
        public string? IconClass { get; set; }
        public string? Name { get; set; }
        public string? Tooltip { get; set; }
    }

}
