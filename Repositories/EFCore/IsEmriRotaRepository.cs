using Entities.Dtos;
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

        public IQueryable<UYIsEmriRotasi> IsEmriRotasiById(int id)
        {
            IQueryable<UYIsEmriRotasi> result = GetByCondition(x => x.IsEmriRotaID.Equals(id));
            return result;
        }

        public void UpdateIsEmriRotasi(UYIsEmriRotasiUpdateDto isEmriRotasi) => Update(isEmriRotasi);
    }
}
