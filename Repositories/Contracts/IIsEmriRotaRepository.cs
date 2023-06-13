using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRotaRepository : IRepositoryBase<UYIsEmriRotasi>
    {
        IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList();
        IQueryable<UYIsEmriRotasi> IsEmriRotasiById(long id);
        void UpdateIsEmriRotasi (UYIsEmriRotasi isEmriRotasi);
    }
}
