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

        public List<GanttDataSourceDto> GanttDataSource()
        {
            List<GanttDataSourceDto> ganttData = new();
            var aktifIsEmri = _context.UYIsEmri
                .Include(i=> i.Urun)
                .Where(x => !x.IsEmriDurumID.Equals(0) && !x.IsEmriDurumID.Equals(7) && !x.IsEmriDurumID.Equals(8))
                .Select(s=> new
                {
                    IsEmri = s.IsEmriID,
                    UrunAdi = s.Urun!.Adi,
                    Baslangic = s.BaslangicTarihi,
                    Bitis = s.BitisTarihi,
                    UstIs = s.UstIsEmriID

                })
                .OrderBy(o=> o.IsEmri);
            if (aktifIsEmri is not null)
            {
                foreach (var isEmri in aktifIsEmri)
                {
                    ganttData.Add(new GanttDataSourceDto
                    {
                        taskId = (int)isEmri.IsEmri,
                        taskName = isEmri.UrunAdi,
                        startDate = isEmri.Baslangic,
                        endDate = isEmri.Bitis,
                        parentID = (int?)isEmri.UstIs,
                    }) ;
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

        public IQueryable<UYIsEmri> GetAllIsEmriList() => GetAll();

        public IQueryable<UYIsEmri> IsEmriById(int id) => GetByCondition(x => x.IsEmriID.Equals(id));
    }
}
