namespace Entities.Dtos
{
    public class GanttDataSourceDto
    {
        public int IsEmriId { get; set; }
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? BaselineStartDate { get; set; }
        public DateTime? BaselineEndDate { get; set; }
        public int? Duration { get; set; }
        public string DurationUnit { get; set; } = "minutes";
        public bool IsManual { get; set; }
        public int Progress { get; set; }
        public string? Predecessor { get; set; }
        public List<GanttDataSourceDto>? SubTasks { get; set; }
        public int? ParentID { get; set; }
        public int ResourceId { get; set; }
        public List<GanttResourceDto>? Resources { get; set; } 
        public string? Notes { get; set; }
        public int? Work { get; set; }
        public string? customColumn { get; set; }
        public List<IndicatorsModel> Indicators { get; set; } = new();
    }

    public class IndicatorsModel
    {
        public string? Date { get; set; }
        public string? IconClass { get; set; }
        public string? Name { get; set; }
        public string? Tooltip { get; set; }
    }

}
