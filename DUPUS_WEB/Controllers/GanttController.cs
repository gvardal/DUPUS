using DUPUS_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;

namespace DUPUS_WEB.Controllers
{
    public class GanttController : Controller
    {
        public IActionResult Index()
        {

            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();


            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                ResourceId = new int[] { 1 },
            };
            GanttDataSource Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                Predecessor = "2FS",
                ResourceId = new int[] { 2, 3, 5 },
            };
            GanttDataSource Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Predecessor = "3FS",
                Progress = 50,
            };
            Record1.SubTasks.Add(Child1);
            Record1.SubTasks.Add(Child2);
            Record1.SubTasks.Add(Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child4 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 50,
                ResourceId = new int[] { 4 },

            };
            GanttDataSource Child5 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 14),
                Duration = 3,
                Progress = 50,
                Predecessor = "6SS",
                ResourceId = new int[] { 4, 8 },

            };
            Record2.SubTasks.Add(Child4);
            Record2.SubTasks.Add(Child5);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);


            return View(GanttDataSourceCollection);
        }

        public IActionResult UrlDatasource(DataManagerRequest dm)
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();


            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                ResourceId = new int[] { 1 },
            };
            GanttDataSource Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                Predecessor = "2FS",
                ResourceId = new int[] { 2, 3, 5 },
            };
            GanttDataSource Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Predecessor = "3FS",
                Progress = 50,
            };
            Record1.SubTasks.Add(Child1);
            Record1.SubTasks.Add(Child2);
            Record1.SubTasks.Add(Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child4 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 50,
                ResourceId = new int[] { 4 },

            };
            GanttDataSource Child5 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 14),
                Duration = 3,
                Progress = 50,
                Predecessor = "6SS",
                ResourceId = new int[] { 4, 8 },

            };
            Record2.SubTasks.Add(Child4);
            Record2.SubTasks.Add(Child5);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);

            
            var count = GanttDataSourceCollection.Count();
            return Json(new { result = GanttDataSourceCollection, count = count });
        }
    }
}
