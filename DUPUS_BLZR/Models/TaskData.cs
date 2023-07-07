namespace DUPUS_BLZR.Models
{
    public class TaskData
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; } = "minutes";
        public decimal? Progress { get; set; }
        public int? ParentId { get; set; }
        public string Predecessor { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string TaskType { get; set; } = string.Empty;
        public List<ResourceData> Resources { get; set; }
    }
}
