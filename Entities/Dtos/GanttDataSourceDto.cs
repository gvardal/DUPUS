namespace Entities.Dtos
{
    public class GanttDataSourceDto
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime BaselineStartDate { get; set; }
        public DateTime BaselineEndDate { get; set; }
        public int? Duration { get; set; }
        public bool IsManual { get; set; }
        public int Progress { get; set; }
        public string? Predecessor { get; set; }
        public List<GanttDataSourceDto>? SubTasks { get; set; }
        public int[]? ResourceId { get; set; }
        public List<ResourceModelDto>? Resources { get; set; }
        public string? Notes { get; set; }
        public int? Work { get; set; }
        public int ParentID { get; set; }
        public List<IndicatorsModelDto>? Indicators { get; set; }
    }

    public class ResourceModelDto
    {
        public int ResourceId { get; set; }
        public int? ResourceUnit { get; set; }
    }

    public class IndicatorsModelDto
    {
        public string? Date { get; set; }
        public string? IconClass { get; set; }
        public string? Name { get; set; }
        public string? Tooltip { get; set; }
    }

}
