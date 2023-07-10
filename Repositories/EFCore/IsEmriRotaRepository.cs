using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
            IQueryable<UYIsEmriRotasi> result = GetByCondition(x => x.IsEmriRotaID.Equals(id)).AsNoTracking();
            return result;
        }

        public void UpdateIsEmriRotasi(UYIsEmriRotasi isEmriRotasi)
        {
            Update(isEmriRotasi);

        }
    }
}
