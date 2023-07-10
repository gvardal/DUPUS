using Entities.Dtos;
using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRotaRepository : IRepositoryBase<UYIsEmriRotasi>
    {
        IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList();
        IQueryable<UYIsEmriRotasi> IsEmriRotasiById(int id);
        void UpdateIsEmriRotasi (UYIsEmriRotasi isEmriRotasi);
    }
}
