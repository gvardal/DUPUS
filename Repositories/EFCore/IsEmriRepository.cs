using Entities.Dtos;
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
                    mainTask.Add(new GanttMainTaskDto { IsEmriId = (int)main.IsEmri, UrunAdi = main.UrunAdi});
                }
            }

            return mainTask;
        }


        public List<GanttDataSourceDto> GanttSubTask()
        {
            List<GanttDataSourceDto> ganttData = new();
            //var aktifIsEmrileri = _context.UYIsEmri
            //    .Include(i => i.Urun)
            //    .Where(x => !x.IsEmriDurumID.Equals(0) && !x.IsEmriDurumID.Equals(7) && !x.IsEmriDurumID.Equals(8))
            //    .Select(s => new
            //    {
            //        IsEmri = s.IsEmriID,
            //        UrunAdi = s.Urun!.Adi,
            //        Baslangic = s.BaslangicTarihi,
            //        Bitis = s.BitisTarihi,
            //        UstIs = s.UstIsEmriID

            //    })
            //    .OrderBy(o => o.IsEmri);

            //if (aktifIsEmrileri is not null)
            //{
            //    foreach (var isEmri in aktifIsEmrileri)
            //    {
            //        ganttData.Add(new GanttDataSourceDto
            //        {
            //            IsEmriId = (int)isEmri.IsEmri,
            //            TaskName = isEmri.UrunAdi                        
            //        });
            //    }

            //    foreach (var data in ganttData)
            //    {
            //        if (data is not null)
            //        {
            //            var isEmriKonums = _context.UYIsEmriRotasi
            //                            .Where(x => x.IsEmriID.Equals(data.IsEmriId))
            //                            .Select(s => new
            //                            {
            //                                IsEmriRotaId = s.IsEmriRotaID,
            //                                KonumId = s.KonumID,
            //                                BaslangicTarihi = s.PlanlananBaslamaTarihi,
            //                                BitisTarihi = s.PlanlananBitisTarihi,
            //                                TamamlanmaZamani = s.PlanlananTamamlanmaZamani
            //                            }).ToList();

            //            foreach (var konum in isEmriKonums)
            //            {
            //                data.TaskId = konum.IsEmriRotaId;
            //                TimeSpan ts = konum.BitisTarihi - konum.BaslangicTarihi;
            //                data.StartDate = konum.BaslangicTarihi;
            //                data.EndDate = konum.BitisTarihi;
            //                data.Duration = (int)ts.TotalMinutes;
            //                data.ResourceId = konum.KonumId;
            //                data.Resources = new List<GanttResourceDto>
            //                {
            //                    new GanttResourceDto { ResourceId = konum.KonumId,ResourceUnit = 75}
            //                };
            //            }
            //        }
            //    }
            //}
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

        public IQueryable<UYIsEmri> GetAllIsEmriList() => GetAll();

        public IQueryable<UYIsEmri> IsEmriById(int id) => GetByCondition(x => x.IsEmriID.Equals(id));
    }
}
