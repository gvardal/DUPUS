namespace DUPUS_WEB.Models
{
    public partial class ProjectData
    {
        public List<GanttDataSource> GetUrlDataSource()
        {
            List<GanttDataSource> dataCollection = new List<GanttDataSource>();

            //dataCollection = new List<GanttDataSource>() {
            //   new GanttDataSource(){
            //        taskId = 1,
            //        taskName = "Project initiation",
            //        startDate = new DateTime(2019, 03, 29),
            //        endDate = new DateTime(2019, 04, 21),
            //          resources = new List<GanttResource>
            //    {
            //       new GanttResource { resourceId = 1 },
            //       new GanttResource { resourceId = 6 }
            //    }
            //    },
            //   new GanttDataSource(){
            //        taskId = 2,
            //        taskName = "Identify Site location",
            //        startDate = new DateTime(2019, 03, 29),
            //        duration = "2",
            //        progress = 30,
            //        parentID = 1,
            //        resources = new List<GanttResource>
            //    {
            //       new GanttResource { resourceId = 1 },
            //       new GanttResource { resourceId = 6 }
            //    }
            //    },
            //   new GanttDataSource(){
            //        taskId = 3,
            //        taskName = "Perform soil test",
            //        startDate = new DateTime(2019, 03, 29),
            //        duration = "4",
            //        parentID = 1,
            //        resources = new List<GanttResource>
            //            {
            //                new GanttResource { resourceId = 2 },
            //                new GanttResource{ resourceId = 3 },
            //                new GanttResource{ resourceId = 5 }
            //            }
            //    },
            //   new GanttDataSource(){
            //        taskId = 4,
            //        taskName = "Soil test approval",
            //        startDate = new DateTime(2019, 03, 29),
            //        duration = "1",
            //        progress = 30,
            //        parentID = 1,
            //        resources = new List<GanttResource>
            //            {
            //               new GanttResource { resourceId = 5 },
            //            new GanttResource { resourceId = 6 }
            //            }
            //    },
            //   new GanttDataSource(){
            //        taskId = 5,
            //        taskName = "Project estimation",
            //        startDate = new DateTime(2019, 03, 29),
            //        endDate = new DateTime(2019, 04, 21),
            //    },
            //   new GanttDataSource(){
            //        taskId = 6,
            //        taskName = "Develop floor plan for estimation",
            //        startDate = new DateTime(2019, 03, 29),
            //        duration = "3",
            //        progress = 30,
            //        parentID = 5,
            //        resources = new List<GanttResource>
            //            {
            //               new GanttResource { resourceId = 4 }
            //            }
            //    },
            //   new GanttDataSource()
            //   {
            //       taskId = 7,
            //       taskName = "List materials",
            //       startDate = new DateTime(2019, 04, 01),
            //       duration = "3",
            //       parentID = 5,
            //       resources = new List<GanttResource>
            //            {
            //               new GanttResource { resourceId = 3 },
            //             new GanttResource{ resourceId = 4 }
            //            }
            //   },
            //   new GanttDataSource()
            //   {
            //       taskId = 8,
            //       taskName = "Estimation approval",
            //       startDate = new DateTime(2019, 04, 01),
            //       duration = "2",
            //       parentID = 5,
            //       resources = new List<GanttResource>
            //            {
            //               new GanttResource { resourceId = 1 },
            //             new GanttResource{ resourceId = 5 }
            //            }
            //   },
            //   new GanttDataSource()
            //   {
            //       taskId = 9,
            //       taskName = "Sign contract",
            //       startDate = new DateTime(2019, 04, 01),
            //       duration = "1",
            //       predecessor = "8",
            //       progress = 30,
            //       resources = new List<GanttResource>
            //            {
            //               new GanttResource { resourceId = 2 }
            //        }
            //   }
            //};
            return dataCollection;
        }
    }
}
