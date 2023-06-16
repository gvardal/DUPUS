namespace Entities.Dtos
{
    public class GanttDataSourceDto
    {
        public int taskId { get; set; }
        public string? taskName { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string? duration { get; set; }
        public int progress { get; set; }
        public string? predecessor { get; set; }
        public int? parentID { get; set; }
        //public List<GanttResource>? resources { get; set; }
        public string? customColumn { get; set; }
    }
}
