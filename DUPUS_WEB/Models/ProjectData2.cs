using Entities.Dtos;

namespace DUPUS_WEB.Models
{
    public class ProjectData2
    {
        public class GanttResourceModel
        {
            public int resourceId { get; set; }
            public int? ResourceUnit { get; set; }
            public int? ActivityId { get; set; }
        }

        public class GanttDataSourceDto
        {
            public int? taskId { get; set; }
            public string? taskName { get; set; }
            public DateTime? startDate { get; set; }
            public DateTime? endDate { get; set; }
            public int? duration { get; set; }
            public int? progress { get; set; }
            public string? predecessor { get; set; }
            public int[]? resourceId { get; set; }
            public List<GanttDataSourceDto>? SubTasks { get; set; }
        }

        public List<GanttDataSourceDto> GetUrlDataSource()
        {
            List<GanttDataSourceDto> dataCollection = new List<GanttDataSourceDto>();
            dataCollection = new List<GanttDataSourceDto>() {
               new GanttDataSourceDto(){
                    taskId = 1,
                    taskName = "Project initiation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSourceDto(){
                    taskId = 2,
                    taskName = "Identify Site location",
                    startDate = new DateTime(2019, 03, 29),
                    duration = 2,
                    progress = 30,
                },
               new GanttDataSourceDto(){
                    taskId = 3,
                    taskName = "Perform soil test",
                    startDate = new DateTime(2019, 03, 29),
                    duration = 4

                },
               new GanttDataSourceDto(){
                    taskId = 4,
                    taskName = "Soil test approval",
                    startDate = new DateTime(2019, 03, 29),
                    duration = 1

                },
               new GanttDataSourceDto(){
                    taskId = 5,
                    taskName = "Project estimation",
                    startDate = new DateTime(2019, 03, 29),
                    endDate = new DateTime(2019, 04, 21),
                },
               new GanttDataSourceDto(){
                    taskId = 6,
                    taskName = "Develop floor plan for estimation",
                    startDate = new DateTime(2019, 03, 29),
                    duration = 3

                },
               new GanttDataSourceDto()
               {
                   taskId = 7,
                   taskName = "List materials",
                   startDate = new DateTime(2019, 04, 01),
                   duration = 3

               },
               new GanttDataSourceDto()
               {
                   taskId = 8,
                   taskName = "Estimation approval",
                   startDate = new DateTime(2019, 04, 01),
                   duration = 2,

               },
               new GanttDataSourceDto()
               {
                   taskId = 9,
                   taskName = "Sign contract",
                   startDate = new DateTime(2019, 04, 01),
                   duration = 1

               }

            };
            return dataCollection;

        }
    }
}
