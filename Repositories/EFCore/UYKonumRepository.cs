using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class UYKonumRepository : RepositoryBase<UYKonum>, IUYKonumRepository
    {
        public UYKonumRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYKonum> GetAllKonumByKonumId(byte id) => GetByCondition(x=> x.KonumTuruID.Equals(id));

        public IQueryable<UYKonum> GetAllKonumList() => GetAll();
    }
}
