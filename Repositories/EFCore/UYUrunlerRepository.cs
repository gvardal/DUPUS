using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class UYUrunlerRepository : RepositoryBase<UYUrunler>, IUYUrunlerRepository
    {
        public UYUrunlerRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYUrunler> GetAllUrunList() => GetAll();

        public UYUrunler? GetUrunById(int id) => GetByCondition(x => x.UrunID == id).FirstOrDefault();

        public string UrunAdi(int id)
        {
            return GetByCondition(x => x.UrunID == id).First().Adi!;
        }
    }
}
