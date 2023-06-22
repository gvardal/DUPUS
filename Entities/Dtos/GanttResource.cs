namespace Entities.Dtos
{
    public class GanttResource
    {
        public int ResourceId { get; set; }
        public string? ResourceName { get; set; }
        public string? ResourceGroup { get; set; }
        public int? ResourceUnit { get; set; } = 100;
    }
}
