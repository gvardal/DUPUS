﻿using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class IsEmriRepository : RepositoryBase<UYIsEmri>, IIsEmriRepository
    {
        private readonly IUYUrunlerRepository _urunler;
        public IsEmriRepository(RepositoryContext context) : base(context)
        {
            _urunler = new UYUrunlerRepository(context);
        }

        public List<GanttMainTaskDto> GanttMainTask()
        {
            List<GanttMainTaskDto> mainTask = new();
            var aktifIsEmri = _context.UYIsEmri
                .Include(i => i.Urun)
                .Where(x => !x.IsEmriDurumID.Equals(0) && !x.IsEmriDurumID.Equals(7) && !x.IsEmriDurumID.Equals(8))
                .Select(s => new
                {
                    IsEmri = s.IsEmriID,
                    UrunAdi = s.Urun!.Adi,
                })
                .OrderBy(o => o.IsEmri);
            if (aktifIsEmri is not null)
            {
                foreach (var main in aktifIsEmri)
                {
                    mainTask.Add(new GanttMainTaskDto { IsEmriId = (int)main.IsEmri, UrunAdi = main.UrunAdi });
                }
            }
            return mainTask;
        }

        public List<TaskData> GanttTasks()
        {
            List<TaskData> ganttData = new();
            var tasks = _context.UYIsEmriRotasi
                .Include(i => i.IsEmri)
                .Include(i=> i.Konum)
                .Where(x => !x.IsEmri!.IsEmriDurumID.Equals(0) && !x.IsEmri!.IsEmriDurumID.Equals(7) && !x.IsEmri!.IsEmriDurumID.Equals(8)) //&& x.IsEmri.UrunID.Equals(7806)
                .Select(s => new
                {
                    taskId = s.IsEmriRotaID,
                    taskName = s.IsEmri!.Urun!.Adi,
                    startDate = s.PlanlananBaslamaTarihi,
                    endDate = s.PlanlananBitisTarihi,
                    resourceId = s.KonumID,
                    resourceName = s.Konum!.Ad,
                    recourceGroup = s.Konum!.KonumKodu,
                    parentId = s.IsEmri.UretimPlaniID,
                    //predecessor = s.OncekiIsEmriRotaID,
                    duration = Convert.ToInt32(s.PlanlananTamamlanmaZamani / 60),
                    progress = s.GerceklesenCikti == 0 ? 0 : Convert.ToDecimal((s.GerceklesenCikti / s.PlanlananGirdi) * 100),
                }).OrderBy(O => O.taskName).ThenBy(O => O.startDate);
            if (tasks is not null)
            {
                foreach (var task in tasks)
                {
                    ganttData.Add(new TaskData
                    {
                        TaskId = task.taskId,
                        TaskName = task.taskName!,
                        StartDate = task.startDate,
                        Duration = task.duration,
                        ParentId = Convert.ToInt32(task.parentId!),
                        //predecessor = $"{task.predecessor}FS",
                        Progress = task.progress,
                        Resources = new List<ResourceData> {
                            new ResourceData {
                                ResourceId = task.resourceId,
                                ResourceName = task.resourceName!,
                                ResourceGroup  = task.recourceGroup,
                            } }
                    });
                }
            }
            return ganttData;
        }

        public UYIsEmriDurumu? GetIsEmriDurumuById(int id)
        {
            return _context.UYIsEmriDurumu.Where(x => x.IsEmriDurumId.Equals(id)).SingleOrDefault();
        }

        public IQueryable<UYIsEmriDurumu> GetAllIsEmriDurumuList()
        {
            return _context.UYIsEmriDurumu.AsNoTracking();
        }

        public IQueryable<UYIsEmri> GetAllIsEmriList(bool trackChanges) => GetAll(trackChanges);

        public IQueryable<UYIsEmri> IsEmriById(int id, bool trackChanges) => GetByCondition(x => x.IsEmriID.Equals(id), trackChanges);


        // For Blazor Project 
        public List<WeeklyPlanDto> WeeklyPlanWorkOrders(string konumId)
        {
            List<WeeklyPlanDto> weeklyPlan = new();
            var result = _context.UYIsEmriRotasi
                .Include(i => i.IsEmri)
                .Where(x => (!x.IsEmri!.IsEmriDurumID.Equals(0) && !x.IsEmri!.IsEmriDurumID.Equals(7) && !x.IsEmri!.IsEmriDurumID.Equals(8))
                    && x.KonumID == Convert.ToInt64(konumId))
                .Select(s => new
                {
                    taskId = s.IsEmriRotaID,
                    taskName = s.IsEmri!.Urun!.Adi,
                    startDate = s.PlanlananBaslamaTarihi,
                    endDate = s.PlanlananBitisTarihi,
                    resource = s.KonumID,
                    predecessor = s.OncekiIsEmriRotaID,
                    duration = Convert.ToInt32(s.PlanlananTamamlanmaZamani / 60),
                    progress = s.GerceklesenCikti == 0 ? 0 : Convert.ToDecimal((s.GerceklesenCikti / s.PlanlananGirdi)),
                }).AsNoTracking();

            if (result is not null)
            {
                foreach (var wo in result)
                {
                    weeklyPlan.Add(new WeeklyPlanDto
                    {
                        Id = wo.taskId,
                        Subject = wo.taskName!,
                        StartTime = wo.startDate,
                        EndTime = wo.endDate
                    });
                }
            }
            return weeklyPlan;
        }

        public List<TaskData> GanttUretimPlani()
        {
            List<TaskData> ganttData = new();
            var tasks = _context.UYIsEmriRotasi
                .Include(i => i.IsEmri)
                .Include(i => i.IsEmri!.UretimPlani)
                .Where(x => !x.IsEmri!.IsEmriDurumID.Equals(0) && !x.IsEmri!.IsEmriDurumID.Equals(7) && !x.IsEmri!.IsEmriDurumID.Equals(8)) 
                .Select(s => new
                {
                    taskId = s.IsEmri!.UretimPlaniID,
                    taskName = string.Empty,
                    startDate = s.IsEmri!.UretimPlani!.PlanlananBaslamaTarihi,
                    endDate = s.IsEmri!.UretimPlani!.PlanlananBitimTarihi,
                }).Distinct().OrderBy(O => O.taskId).ThenBy(O => O.startDate);
            if (tasks is not null)
            {
                foreach (var task in tasks)
                {
                    ganttData.Add(new TaskData
                    {
                        TaskId = Convert.ToInt32(task.taskId),
                        TaskName = task.taskName!,
                        StartDate = task.startDate,
                        EndDate = task.endDate
                    });
                }
            }
            return ganttData;
        }

    }
}
