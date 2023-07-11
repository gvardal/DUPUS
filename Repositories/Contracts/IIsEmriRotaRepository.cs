using Entities.Dtos;
using Entities.Models;

namespace Repositories.Contracts
{
    public interface IIsEmriRotaRepository : IRepositoryBase<UYIsEmriRotasi>
    {
        IQueryable<UYIsEmriRotasi> GetAllIsEmriRotaList(bool trackChanges);
        IQueryable<UYIsEmriRotasi> IsEmriRotasiById(int id,bool trackChanges);
        void UpdateIsEmriRotasi (UYIsEmriRotasi isEmriRotasi);
    }
}
