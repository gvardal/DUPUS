using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class IsEmriRepository : RepositoryBase<UYIsEmri>, IIsEmriRepository
    {
        public IsEmriRepository(RepositoryContext context) : base(context)
        {
        }

        public List<GanttDataSourceDto> GanttDataSource()
        {
            List<GanttDataSourceDto> ganttData = new();
            var aktifIsEmri = _context.UYIsEmri
                .Where(x => !x.IsEmriDurumID.Equals(0) && !x.IsEmriDurumID.Equals(7) && !x.IsEmriDurumID.Equals(8))
                .OrderBy(o=> o.IsEmriID);
            if (aktifIsEmri is not null)
            {
                foreach (var isEmri in aktifIsEmri)
                {
                    ganttData.Add(new GanttDataSourceDto 
                    {
                        taskId = (int)isEmri.IsEmriID,
                        taskName = $"Test-{isEmri.IsEmriID}",
                        startDate = isEmri.BaslangicTarihi,
                        endDate = isEmri.BitisTarihi,
                        parentID = (int?)isEmri.UstIsEmriID
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

        public IQueryable<UYIsEmri> GetAllIsEmriList() => GetAll();

        public IQueryable<UYIsEmri> IsEmriById(int id) => GetByCondition(x => x.IsEmriID.Equals(id));
    }
}
