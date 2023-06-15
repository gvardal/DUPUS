using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class UYKonumTuruRepository : RepositoryBase<UYKonumTuru>, IUYKonumTuruRepository
    {
        public UYKonumTuruRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYKonumTuru> GetAllKonumTuru() => GetAll();
    }
}
