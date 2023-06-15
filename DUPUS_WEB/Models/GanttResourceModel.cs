namespace DUPUS_WEB.Models
{
    public partial class ProjectData
    {
        public class GanttResourceModel
        {
            public int resourceId { get; set; }
            public int? ResourceUnit { get; set; }
            public int? ActivityId { get; set; }
        }
    }
}
