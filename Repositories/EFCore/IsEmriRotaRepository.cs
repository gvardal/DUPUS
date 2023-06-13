using Entities.Models;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class IsEmriRotaRepository : RepositoryBase<UYIsEmriRotasi>, IIsEmriRotaRepository
    {
        public IsEmriRotaRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList() => GetAll();

        public IQueryable<UYIsEmriRotasi> IsEmriRotasiById(long id) => GetByCondition(x=> x.IsEmriID.Equals(id));

        public void UpdateIsEmriRotasi(UYIsEmriRotasi isEmriRotasi) => Update(isEmriRotasi);
    }
}
