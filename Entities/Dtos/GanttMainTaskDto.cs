namespace Entities.Dtos
{
    public class GanttMainTaskDto
    {
        public int IsEmriId { get; set; }
        public string? UrunAdi { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Duration { get; set; }
        public int? Progress { get; set; }
    }
}
